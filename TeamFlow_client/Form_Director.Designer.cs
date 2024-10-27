namespace TeamFlow_client
{
    partial class Form_Director
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_departments = new System.Windows.Forms.Label();
            this.departmentsComboBox = new System.Windows.Forms.ComboBox();
            this.button_loadDepartments = new System.Windows.Forms.Button();
            this.listBox_employees = new System.Windows.Forms.ListBox();
            this.label_employees = new System.Windows.Forms.Label();
            this.listBox_managers = new System.Windows.Forms.ListBox();
            this.label_managers = new System.Windows.Forms.Label();
            this.button_sendEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_departments
            // 
            this.label_departments.AutoSize = true;
            this.label_departments.Location = new System.Drawing.Point(58, 106);
            this.label_departments.Name = "label_departments";
            this.label_departments.Size = new System.Drawing.Size(84, 16);
            this.label_departments.TabIndex = 0;
            this.label_departments.Text = "Departments";
            // 
            // departmentsComboBox
            // 
            this.departmentsComboBox.FormattingEnabled = true;
            this.departmentsComboBox.Location = new System.Drawing.Point(61, 125);
            this.departmentsComboBox.Name = "departmentsComboBox";
            this.departmentsComboBox.Size = new System.Drawing.Size(121, 24);
            this.departmentsComboBox.TabIndex = 1;
            this.departmentsComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentsComboBox_SelectedIndexChanged);
            // 
            // button_loadDepartments
            // 
            this.button_loadDepartments.Location = new System.Drawing.Point(61, 312);
            this.button_loadDepartments.Name = "button_loadDepartments";
            this.button_loadDepartments.Size = new System.Drawing.Size(139, 32);
            this.button_loadDepartments.TabIndex = 2;
            this.button_loadDepartments.Text = "Load Departments";
            this.button_loadDepartments.UseVisualStyleBackColor = true;
            this.button_loadDepartments.Click += new System.EventHandler(this.button_loadDepartments_Click);
            // 
            // listBox_employees
            // 
            this.listBox_employees.FormattingEnabled = true;
            this.listBox_employees.ItemHeight = 16;
            this.listBox_employees.Location = new System.Drawing.Point(285, 66);
            this.listBox_employees.Name = "listBox_employees";
            this.listBox_employees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_employees.Size = new System.Drawing.Size(358, 180);
            this.listBox_employees.TabIndex = 3;
            // 
            // label_employees
            // 
            this.label_employees.AutoSize = true;
            this.label_employees.Location = new System.Drawing.Point(282, 47);
            this.label_employees.Name = "label_employees";
            this.label_employees.Size = new System.Drawing.Size(76, 16);
            this.label_employees.TabIndex = 4;
            this.label_employees.Text = "Employees";
            // 
            // listBox_managers
            // 
            this.listBox_managers.FormattingEnabled = true;
            this.listBox_managers.ItemHeight = 16;
            this.listBox_managers.Location = new System.Drawing.Point(285, 312);
            this.listBox_managers.Name = "listBox_managers";
            this.listBox_managers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_managers.Size = new System.Drawing.Size(358, 212);
            this.listBox_managers.TabIndex = 5;
            // 
            // label_managers
            // 
            this.label_managers.AutoSize = true;
            this.label_managers.Location = new System.Drawing.Point(282, 293);
            this.label_managers.Name = "label_managers";
            this.label_managers.Size = new System.Drawing.Size(68, 16);
            this.label_managers.TabIndex = 6;
            this.label_managers.Text = "Managers";
            // 
            // button_sendEmail
            // 
            this.button_sendEmail.Location = new System.Drawing.Point(61, 455);
            this.button_sendEmail.Name = "button_sendEmail";
            this.button_sendEmail.Size = new System.Drawing.Size(139, 31);
            this.button_sendEmail.TabIndex = 7;
            this.button_sendEmail.Text = "Send Email";
            this.button_sendEmail.UseVisualStyleBackColor = true;
            this.button_sendEmail.Click += new System.EventHandler(this.button_sendEmail_Click);
            // 
            // Form_Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.button_sendEmail);
            this.Controls.Add(this.label_managers);
            this.Controls.Add(this.listBox_managers);
            this.Controls.Add(this.label_employees);
            this.Controls.Add(this.listBox_employees);
            this.Controls.Add(this.button_loadDepartments);
            this.Controls.Add(this.departmentsComboBox);
            this.Controls.Add(this.label_departments);
            this.Name = "Form_Director";
            this.Text = "Form_Director";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_departments;
        private System.Windows.Forms.ComboBox departmentsComboBox;
        private System.Windows.Forms.Button button_loadDepartments;
        private System.Windows.Forms.ListBox listBox_employees;
        private System.Windows.Forms.Label label_employees;
        private System.Windows.Forms.ListBox listBox_managers;
        private System.Windows.Forms.Label label_managers;
        private System.Windows.Forms.Button button_sendEmail;
    }
}

