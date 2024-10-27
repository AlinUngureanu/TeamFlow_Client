using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Windows.Forms;

namespace TeamFlow_client
{
    public partial class Form_Director : Form
    {
        HttpClient client = new HttpClient();

        public Form_Director()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://localhost:8083/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void button_loadDepartments_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = client.GetAsync("departments").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;

                List<Department> departments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Department>>(resultString);

                departmentsComboBox.DataSource = departments;
                departmentsComboBox.DisplayMember = "name";
            }
        }

        private void departmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = client.GetAsync("departments").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;

                List<Department> departments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Department>>(resultString);

                for (int i = 0; i < departments.Count; i++)
                {
                    if (departmentsComboBox.SelectedItem != null)
                    {
                        string selectedText = departmentsComboBox.GetItemText(departmentsComboBox.SelectedItem);
                        if (selectedText == departments[i].name)
                        {
                            listBox_employees.Items.Clear();

                            if (departments[i].employees.Count == 0)
                            {
                                listBox_employees.Items.Add("This department doesn't contains any employees.");
                            }
                            else
                            {
                                for (int j = 0; j < departments[i].employees.Count; j++)
                                {
                                    listBox_employees.Items.Add(departments[i].employees[j].name);
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < departments.Count; i++)
                {
                    if (departmentsComboBox.SelectedItem != null)
                    {
                        string selectedText = departmentsComboBox.GetItemText(departmentsComboBox.SelectedItem);
                        if (selectedText == departments[i].name)
                        {
                            listBox_managers.Items.Clear();

                            if (departments[i].employees.Count == 0)
                            {
                                listBox_managers.Items.Add("This department doesn't contains any managers.");
                            }
                            else
                            {
                                for (int j = 0; j < departments[i].employees.Count; j++)
                                {
                                    if (departments[i].employees[j].isManager == true)
                                    {
                                        listBox_managers.Items.Add(departments[i].employees[j].name);
                                    }
                                }
                                if (listBox_managers.Items.Count == 0)
                                {
                                    listBox_managers.Items.Add("This department doesn't contains any managers.");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button_sendEmail_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = client.GetAsync("departments").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;

                List<Department> departments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Department>>(resultString);

                List<string> emailLists = new List<string>();

                if (listBox_employees.SelectedItems.Count > 0)
                {
                    List<string> employeeNames = new List<string>();

                    foreach (var selectedItem in listBox_employees.SelectedItems)
                    {
                        employeeNames.Add(selectedItem.ToString());
                    }

                    foreach (var employeeName in employeeNames)
                    {
                        foreach (var department in departments)
                        {
                            foreach (var employee in department.employees)
                            {
                                if (employeeName == employee.name)
                                {
                                    emailLists.Add(employee.email);
                                }
                            }
                        }
                    }
                }

                if (emailLists.Count > 0)
                {
                    foreach (var email in emailLists)
                    {
                        MailMessage mailMessage = new MailMessage();
                        mailMessage.From = new MailAddress("user@yahoo.com");
                        mailMessage.To.Add(email);
                        mailMessage.Subject = "Subject";
                        mailMessage.Body = "Please come to the meeting tomorrow morning!";

                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.Host = "smtp.mail.yahoo.com";
                        smtpClient.Port = 587;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential("user@yahoo.com", "password");
                        smtpClient.EnableSsl = true;

                        try
                        {
                            smtpClient.Send(mailMessage);
                            MessageBox.Show("Email sent successfully.", "Message");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error sending email: " + ex.Message, "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have not selected any employees!", "Error");
                }
            }
        }
    }

    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Employee> employees { get; set; }
    }

    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isManager { get; set; }
        public int department { get; set; }
        public string email { get; set; }
    }
}