namespace dbenson2747SeniorCitizenProject2B
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label empNameLabel;
            System.Windows.Forms.Label empAgeLabel;
            System.Windows.Forms.Label empGenderLabel;
            System.Windows.Forms.Label empDateOfBirthLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label serviceDescriptionLabel;
            System.Windows.Forms.Label serviceRateHourlyLabel;
            System.Windows.Forms.Label serviceRateDailyLabel;
            System.Windows.Forms.Label serviceRateWeeklyLabel;
            this.employeeIDLabelText = new System.Windows.Forms.Label();
            this.empFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.empLastNameTextBox = new System.Windows.Forms.TextBox();
            this.empAgeTextBox = new System.Windows.Forms.TextBox();
            this.empGenderTextBox = new System.Windows.Forms.TextBox();
            this.empDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seniorCitizensDataSet = new dbenson2747SeniorCitizenProject2B.SeniorCitizensDataSet();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.weeklyCheckBox = new System.Windows.Forms.CheckBox();
            this.dailyCheckBox = new System.Windows.Forms.CheckBox();
            this.hourlyCheckBox = new System.Windows.Forms.CheckBox();
            this.servicesComboBox = new System.Windows.Forms.ComboBox();
            this.serviceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.serviceRateHourlyTextBox = new System.Windows.Forms.TextBox();
            this.serviceRateDailyTextBox = new System.Windows.Forms.TextBox();
            this.serviceRateWeeklyTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.moveNextButton = new System.Windows.Forms.Button();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.movePreviousButton = new System.Windows.Forms.Button();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new dbenson2747SeniorCitizenProject2B.SeniorCitizensDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new dbenson2747SeniorCitizenProject2B.SeniorCitizensDataSetTableAdapters.TableAdapterManager();
            this.serviceTableAdapter = new dbenson2747SeniorCitizenProject2B.SeniorCitizensDataSetTableAdapters.ServiceTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            employeeIDLabel = new System.Windows.Forms.Label();
            empNameLabel = new System.Windows.Forms.Label();
            empAgeLabel = new System.Windows.Forms.Label();
            empGenderLabel = new System.Windows.Forms.Label();
            empDateOfBirthLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            serviceIDLabel = new System.Windows.Forms.Label();
            serviceDescriptionLabel = new System.Windows.Forms.Label();
            serviceRateHourlyLabel = new System.Windows.Forms.Label();
            serviceRateDailyLabel = new System.Windows.Forms.Label();
            serviceRateWeeklyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorCitizensDataSet)).BeginInit();
            this.servicesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(61, 40);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 1;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // empNameLabel
            // 
            empNameLabel.AutoSize = true;
            empNameLabel.Location = new System.Drawing.Point(61, 82);
            empNameLabel.Name = "empNameLabel";
            empNameLabel.Size = new System.Drawing.Size(62, 13);
            empNameLabel.TabIndex = 3;
            empNameLabel.Text = "Emp Name:";
            // 
            // empAgeLabel
            // 
            empAgeLabel.AutoSize = true;
            empAgeLabel.Location = new System.Drawing.Point(61, 120);
            empAgeLabel.Name = "empAgeLabel";
            empAgeLabel.Size = new System.Drawing.Size(53, 13);
            empAgeLabel.TabIndex = 7;
            empAgeLabel.Text = "Emp Age:";
            // 
            // empGenderLabel
            // 
            empGenderLabel.AutoSize = true;
            empGenderLabel.Location = new System.Drawing.Point(61, 159);
            empGenderLabel.Name = "empGenderLabel";
            empGenderLabel.Size = new System.Drawing.Size(69, 13);
            empGenderLabel.TabIndex = 9;
            empGenderLabel.Text = "Emp Gender:";
            // 
            // empDateOfBirthLabel
            // 
            empDateOfBirthLabel.AutoSize = true;
            empDateOfBirthLabel.Location = new System.Drawing.Point(61, 204);
            empDateOfBirthLabel.Name = "empDateOfBirthLabel";
            empDateOfBirthLabel.Size = new System.Drawing.Size(95, 13);
            empDateOfBirthLabel.TabIndex = 11;
            empDateOfBirthLabel.Text = "Emp Date Of Birth:";
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(64, 242);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(36, 13);
            clientIDLabel.TabIndex = 12;
            clientIDLabel.Text = "Client:";
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Location = new System.Drawing.Point(29, 39);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(60, 13);
            serviceIDLabel.TabIndex = 0;
            serviceIDLabel.Text = "Service ID:";
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.AutoSize = true;
            serviceDescriptionLabel.Location = new System.Drawing.Point(29, 72);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new System.Drawing.Size(102, 13);
            serviceDescriptionLabel.TabIndex = 2;
            serviceDescriptionLabel.Text = "Service Description:";
            // 
            // serviceRateHourlyLabel
            // 
            serviceRateHourlyLabel.AutoSize = true;
            serviceRateHourlyLabel.Location = new System.Drawing.Point(29, 104);
            serviceRateHourlyLabel.Name = "serviceRateHourlyLabel";
            serviceRateHourlyLabel.Size = new System.Drawing.Size(105, 13);
            serviceRateHourlyLabel.TabIndex = 4;
            serviceRateHourlyLabel.Text = "Service Rate Hourly:";
            // 
            // serviceRateDailyLabel
            // 
            serviceRateDailyLabel.AutoSize = true;
            serviceRateDailyLabel.Location = new System.Drawing.Point(29, 138);
            serviceRateDailyLabel.Name = "serviceRateDailyLabel";
            serviceRateDailyLabel.Size = new System.Drawing.Size(98, 13);
            serviceRateDailyLabel.TabIndex = 6;
            serviceRateDailyLabel.Text = "Service Rate Daily:";
            // 
            // serviceRateWeeklyLabel
            // 
            serviceRateWeeklyLabel.AutoSize = true;
            serviceRateWeeklyLabel.Location = new System.Drawing.Point(29, 177);
            serviceRateWeeklyLabel.Name = "serviceRateWeeklyLabel";
            serviceRateWeeklyLabel.Size = new System.Drawing.Size(111, 13);
            serviceRateWeeklyLabel.TabIndex = 8;
            serviceRateWeeklyLabel.Text = "Service Rate Weekly:";
            // 
            // employeeIDLabelText
            // 
            this.employeeIDLabelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeIDLabelText.Location = new System.Drawing.Point(161, 40);
            this.employeeIDLabelText.Name = "employeeIDLabelText";
            this.employeeIDLabelText.Size = new System.Drawing.Size(59, 23);
            this.employeeIDLabelText.TabIndex = 2;
            this.employeeIDLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empFirstNameTextBox
            // 
            this.empFirstNameTextBox.Location = new System.Drawing.Point(161, 79);
            this.empFirstNameTextBox.Name = "empFirstNameTextBox";
            this.empFirstNameTextBox.Size = new System.Drawing.Size(71, 20);
            this.empFirstNameTextBox.TabIndex = 4;
            this.empFirstNameTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.empFirstNameTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.empFirstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.empFirstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // empLastNameTextBox
            // 
            this.empLastNameTextBox.Location = new System.Drawing.Point(250, 79);
            this.empLastNameTextBox.Name = "empLastNameTextBox";
            this.empLastNameTextBox.Size = new System.Drawing.Size(71, 20);
            this.empLastNameTextBox.TabIndex = 6;
            this.empLastNameTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.empLastNameTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.empLastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.empLastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // empAgeTextBox
            // 
            this.empAgeTextBox.Location = new System.Drawing.Point(161, 117);
            this.empAgeTextBox.Name = "empAgeTextBox";
            this.empAgeTextBox.Size = new System.Drawing.Size(44, 20);
            this.empAgeTextBox.TabIndex = 8;
            this.empAgeTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.empAgeTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.empAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.empAgeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // empGenderTextBox
            // 
            this.empGenderTextBox.Location = new System.Drawing.Point(161, 156);
            this.empGenderTextBox.Name = "empGenderTextBox";
            this.empGenderTextBox.Size = new System.Drawing.Size(59, 20);
            this.empGenderTextBox.TabIndex = 10;
            this.empGenderTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.empGenderTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.empGenderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.empGenderTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // empDateOfBirthDateTimePicker
            // 
            this.empDateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "EmpDateOfBirth", true));
            this.empDateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.empDateOfBirthDateTimePicker.Location = new System.Drawing.Point(161, 200);
            this.empDateOfBirthDateTimePicker.Name = "empDateOfBirthDateTimePicker";
            this.empDateOfBirthDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.empDateOfBirthDateTimePicker.TabIndex = 12;
            this.empDateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.seniorCitizensDataSet;
            // 
            // seniorCitizensDataSet
            // 
            this.seniorCitizensDataSet.DataSetName = "SeniorCitizensDataSet";
            this.seniorCitizensDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(161, 239);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(93, 21);
            this.clientComboBox.TabIndex = 13;
            this.clientComboBox.SelectedValueChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.weeklyCheckBox);
            this.servicesGroupBox.Controls.Add(this.dailyCheckBox);
            this.servicesGroupBox.Controls.Add(this.hourlyCheckBox);
            this.servicesGroupBox.Controls.Add(this.servicesComboBox);
            this.servicesGroupBox.Controls.Add(serviceIDLabel);
            this.servicesGroupBox.Controls.Add(serviceDescriptionLabel);
            this.servicesGroupBox.Controls.Add(this.serviceDescriptionTextBox);
            this.servicesGroupBox.Controls.Add(serviceRateHourlyLabel);
            this.servicesGroupBox.Controls.Add(this.serviceRateHourlyTextBox);
            this.servicesGroupBox.Controls.Add(serviceRateDailyLabel);
            this.servicesGroupBox.Controls.Add(this.serviceRateDailyTextBox);
            this.servicesGroupBox.Controls.Add(serviceRateWeeklyLabel);
            this.servicesGroupBox.Controls.Add(this.serviceRateWeeklyTextBox);
            this.servicesGroupBox.Location = new System.Drawing.Point(382, 31);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(402, 231);
            this.servicesGroupBox.TabIndex = 14;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Select Client Service:";
            // 
            // weeklyCheckBox
            // 
            this.weeklyCheckBox.AutoSize = true;
            this.weeklyCheckBox.Location = new System.Drawing.Point(227, 176);
            this.weeklyCheckBox.Name = "weeklyCheckBox";
            this.weeklyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.weeklyCheckBox.TabIndex = 13;
            this.weeklyCheckBox.UseVisualStyleBackColor = true;
            this.weeklyCheckBox.CheckStateChanged += new System.EventHandler(this.weeklyCheckBox_CheckStateChanged);
            // 
            // dailyCheckBox
            // 
            this.dailyCheckBox.AutoSize = true;
            this.dailyCheckBox.Location = new System.Drawing.Point(227, 138);
            this.dailyCheckBox.Name = "dailyCheckBox";
            this.dailyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dailyCheckBox.TabIndex = 12;
            this.dailyCheckBox.UseVisualStyleBackColor = true;
            this.dailyCheckBox.CheckStateChanged += new System.EventHandler(this.dailyCheckBox_CheckStateChanged);
            // 
            // hourlyCheckBox
            // 
            this.hourlyCheckBox.AutoSize = true;
            this.hourlyCheckBox.Location = new System.Drawing.Point(227, 103);
            this.hourlyCheckBox.Name = "hourlyCheckBox";
            this.hourlyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hourlyCheckBox.TabIndex = 11;
            this.hourlyCheckBox.UseVisualStyleBackColor = true;
            this.hourlyCheckBox.CheckStateChanged += new System.EventHandler(this.hourlyCheckBox_CheckStateChanged);
            // 
            // servicesComboBox
            // 
            this.servicesComboBox.FormattingEnabled = true;
            this.servicesComboBox.Location = new System.Drawing.Point(146, 36);
            this.servicesComboBox.Name = "servicesComboBox";
            this.servicesComboBox.Size = new System.Drawing.Size(35, 21);
            this.servicesComboBox.TabIndex = 10;
            this.servicesComboBox.SelectedValueChanged += new System.EventHandler(this.servicesComboBox_SelectedValueChanged);
            // 
            // serviceDescriptionTextBox
            // 
            this.serviceDescriptionTextBox.Location = new System.Drawing.Point(146, 69);
            this.serviceDescriptionTextBox.Name = "serviceDescriptionTextBox";
            this.serviceDescriptionTextBox.Size = new System.Drawing.Size(161, 20);
            this.serviceDescriptionTextBox.TabIndex = 3;
            this.serviceDescriptionTextBox.FontChanged += new System.EventHandler(this.bufferCurrentText);
            this.serviceDescriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.serviceDescriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // serviceRateHourlyTextBox
            // 
            this.serviceRateHourlyTextBox.Location = new System.Drawing.Point(146, 99);
            this.serviceRateHourlyTextBox.Name = "serviceRateHourlyTextBox";
            this.serviceRateHourlyTextBox.Size = new System.Drawing.Size(68, 20);
            this.serviceRateHourlyTextBox.TabIndex = 5;
            this.serviceRateHourlyTextBox.FontChanged += new System.EventHandler(this.bufferCurrentText);
            this.serviceRateHourlyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // serviceRateDailyTextBox
            // 
            this.serviceRateDailyTextBox.Location = new System.Drawing.Point(146, 134);
            this.serviceRateDailyTextBox.Name = "serviceRateDailyTextBox";
            this.serviceRateDailyTextBox.Size = new System.Drawing.Size(68, 20);
            this.serviceRateDailyTextBox.TabIndex = 7;
            this.serviceRateDailyTextBox.FontChanged += new System.EventHandler(this.bufferCurrentText);
            this.serviceRateDailyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // serviceRateWeeklyTextBox
            // 
            this.serviceRateWeeklyTextBox.Location = new System.Drawing.Point(146, 173);
            this.serviceRateWeeklyTextBox.Name = "serviceRateWeeklyTextBox";
            this.serviceRateWeeklyTextBox.Size = new System.Drawing.Size(68, 20);
            this.serviceRateWeeklyTextBox.TabIndex = 9;
            this.serviceRateWeeklyTextBox.FontChanged += new System.EventHandler(this.bufferCurrentText);
            this.serviceRateWeeklyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(466, 356);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(74, 23);
            this.newButton.TabIndex = 38;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(385, 356);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 23);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 356);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 23);
            this.cancelButton.TabIndex = 36;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(226, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 23);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(477, 330);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(39, 23);
            this.moveLastButton.TabIndex = 34;
            this.moveLastButton.Text = ">|";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // moveNextButton
            // 
            this.moveNextButton.Location = new System.Drawing.Point(432, 330);
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.Size = new System.Drawing.Size(39, 23);
            this.moveNextButton.TabIndex = 33;
            this.moveNextButton.Text = ">";
            this.moveNextButton.UseVisualStyleBackColor = true;
            this.moveNextButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPositionLabel.Location = new System.Drawing.Point(340, 330);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(86, 23);
            this.currentPositionLabel.TabIndex = 32;
            this.currentPositionLabel.Text = "000 of 000";
            this.currentPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.Location = new System.Drawing.Point(295, 330);
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.Size = new System.Drawing.Size(39, 23);
            this.movePreviousButton.TabIndex = 31;
            this.movePreviousButton.Text = "<";
            this.movePreviousButton.UseVisualStyleBackColor = true;
            this.movePreviousButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(250, 330);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(39, 23);
            this.moveFirstButton.TabIndex = 30;
            this.moveFirstButton.Text = "|<";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.seniorCitizensDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager.UpdateOrder = dbenson2747SeniorCitizenProject2B.SeniorCitizensDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.seniorCitizensDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 414);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moveLastButton);
            this.Controls.Add(this.moveNextButton);
            this.Controls.Add(this.currentPositionLabel);
            this.Controls.Add(this.movePreviousButton);
            this.Controls.Add(this.moveFirstButton);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(empDateOfBirthLabel);
            this.Controls.Add(this.empDateOfBirthDateTimePicker);
            this.Controls.Add(empGenderLabel);
            this.Controls.Add(this.empGenderTextBox);
            this.Controls.Add(empAgeLabel);
            this.Controls.Add(this.empAgeTextBox);
            this.Controls.Add(this.empLastNameTextBox);
            this.Controls.Add(empNameLabel);
            this.Controls.Add(this.empFirstNameTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDLabelText);
            this.Name = "Form1";
            this.Text = "dbenson2747ex1b : Unbound Controls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorCitizensDataSet)).EndInit();
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeniorCitizensDataSet seniorCitizensDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;        
        private SeniorCitizensDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label employeeIDLabelText;
        private System.Windows.Forms.TextBox empFirstNameTextBox;
        private System.Windows.Forms.TextBox empLastNameTextBox;
        private System.Windows.Forms.TextBox empAgeTextBox;
        private System.Windows.Forms.TextBox empGenderTextBox;
        private System.Windows.Forms.DateTimePicker empDateOfBirthDateTimePicker;
        
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.GroupBox servicesGroupBox;        
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.TextBox serviceDescriptionTextBox;
        private System.Windows.Forms.TextBox serviceRateHourlyTextBox;
        private System.Windows.Forms.TextBox serviceRateDailyTextBox;
        private System.Windows.Forms.TextBox serviceRateWeeklyTextBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.ComboBox servicesComboBox;
        private System.Windows.Forms.CheckBox weeklyCheckBox;
        private System.Windows.Forms.CheckBox dailyCheckBox;
        private System.Windows.Forms.CheckBox hourlyCheckBox;
    }
}

