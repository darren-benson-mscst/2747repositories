namespace dbenson2747ex2a
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
            this.businessEntityIDLabel = new System.Windows.Forms.Label();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.acctNumberTextBox = new System.Windows.Forms.TextBox();
            this.preferredVendorCheckBox = new System.Windows.Forms.CheckBox();
            this.vendorActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.addressModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.entityIDLabel = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.cityStateLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.acctNumberLabel = new System.Windows.Forms.Label();
            this.creditRatingLabel = new System.Windows.Forms.Label();
            this.modifiedDateLabel = new System.Windows.Forms.Label();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.movePreviousButton = new System.Windows.Forms.Button();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.moveNextButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.creditRatingComboBox = new System.Windows.Forms.ComboBox();
            this.adventureWorksDataSet1 = new dbenson2747ex2a.AdventureWorksDataSet();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter1 = new dbenson2747ex2a.AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // businessEntityIDLabel
            // 
            this.businessEntityIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.businessEntityIDLabel.Location = new System.Drawing.Point(121, 45);
            this.businessEntityIDLabel.Name = "businessEntityIDLabel";
            this.businessEntityIDLabel.Size = new System.Drawing.Size(52, 22);
            this.businessEntityIDLabel.TabIndex = 1;
            this.businessEntityIDLabel.Text = "00000";
            this.businessEntityIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.Location = new System.Drawing.Point(121, 70);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.vendorNameTextBox.TabIndex = 3;
            this.vendorNameTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.vendorNameTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.vendorNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressed);
            this.vendorNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(121, 96);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(188, 20);
            this.address1TextBox.TabIndex = 5;
            this.address1TextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.address1TextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.address1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressed);
            this.address1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(121, 122);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(188, 20);
            this.address2TextBox.TabIndex = 7;
            this.address2TextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.address2TextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.address2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressed);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(121, 148);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 9;
            this.cityTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.cityTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressed);
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(236, 148);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(73, 21);
            this.stateComboBox.TabIndex = 10;
            this.stateComboBox.SelectedValueChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(121, 174);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox.TabIndex = 12;
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.postalCodeTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.postalCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressed);
            this.postalCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // acctNumberTextBox
            // 
            this.acctNumberTextBox.Location = new System.Drawing.Point(461, 70);
            this.acctNumberTextBox.Name = "acctNumberTextBox";
            this.acctNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.acctNumberTextBox.TabIndex = 14;
            this.acctNumberTextBox.TextChanged += new System.EventHandler(this.controlValueChanged);
            this.acctNumberTextBox.Enter += new System.EventHandler(this.bufferCurrentText);
            this.acctNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPressed);
            this.acctNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_validateNull);
            // 
            // preferredVendorCheckBox
            // 
            this.preferredVendorCheckBox.AutoSize = true;
            this.preferredVendorCheckBox.Location = new System.Drawing.Point(461, 125);
            this.preferredVendorCheckBox.Name = "preferredVendorCheckBox";
            this.preferredVendorCheckBox.Size = new System.Drawing.Size(80, 17);
            this.preferredVendorCheckBox.TabIndex = 17;
            this.preferredVendorCheckBox.Text = "checkBox1";
            this.preferredVendorCheckBox.UseVisualStyleBackColor = true;
            this.preferredVendorCheckBox.CheckedChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // vendorActiveCheckBox
            // 
            this.vendorActiveCheckBox.AutoSize = true;
            this.vendorActiveCheckBox.Location = new System.Drawing.Point(461, 151);
            this.vendorActiveCheckBox.Name = "vendorActiveCheckBox";
            this.vendorActiveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.vendorActiveCheckBox.TabIndex = 18;
            this.vendorActiveCheckBox.Text = "checkBox2";
            this.vendorActiveCheckBox.UseVisualStyleBackColor = true;
            this.vendorActiveCheckBox.CheckedChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // addressModifiedDateTimePicker
            // 
            this.addressModifiedDateTimePicker.Enabled = false;
            this.addressModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addressModifiedDateTimePicker.Location = new System.Drawing.Point(461, 174);
            this.addressModifiedDateTimePicker.Name = "addressModifiedDateTimePicker";
            this.addressModifiedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.addressModifiedDateTimePicker.TabIndex = 20;
            // 
            // entityIDLabel
            // 
            this.entityIDLabel.AutoSize = true;
            this.entityIDLabel.Location = new System.Drawing.Point(31, 45);
            this.entityIDLabel.Name = "entityIDLabel";
            this.entityIDLabel.Size = new System.Drawing.Size(21, 13);
            this.entityIDLabel.TabIndex = 0;
            this.entityIDLabel.Text = "ID:";
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Location = new System.Drawing.Point(31, 72);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(44, 13);
            this.vendorLabel.TabIndex = 2;
            this.vendorLabel.Text = "Vendor:";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(31, 99);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(57, 13);
            this.address1Label.TabIndex = 4;
            this.address1Label.Text = "Address 1:";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(31, 125);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(57, 13);
            this.address2Label.TabIndex = 6;
            this.address2Label.Text = "Address 2:";
            // 
            // cityStateLabel
            // 
            this.cityStateLabel.AutoSize = true;
            this.cityStateLabel.Location = new System.Drawing.Point(31, 151);
            this.cityStateLabel.Name = "cityStateLabel";
            this.cityStateLabel.Size = new System.Drawing.Size(57, 13);
            this.cityStateLabel.TabIndex = 8;
            this.cityStateLabel.Text = "City/State:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(31, 177);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(25, 13);
            this.zipCodeLabel.TabIndex = 11;
            this.zipCodeLabel.Text = "Zip:";
            // 
            // acctNumberLabel
            // 
            this.acctNumberLabel.AutoSize = true;
            this.acctNumberLabel.Location = new System.Drawing.Point(376, 76);
            this.acctNumberLabel.Name = "acctNumberLabel";
            this.acctNumberLabel.Size = new System.Drawing.Size(39, 13);
            this.acctNumberLabel.TabIndex = 13;
            this.acctNumberLabel.Text = "Acct#:";
            // 
            // creditRatingLabel
            // 
            this.creditRatingLabel.AutoSize = true;
            this.creditRatingLabel.Location = new System.Drawing.Point(376, 99);
            this.creditRatingLabel.Name = "creditRatingLabel";
            this.creditRatingLabel.Size = new System.Drawing.Size(71, 13);
            this.creditRatingLabel.TabIndex = 15;
            this.creditRatingLabel.Text = "Credit Rating:";
            // 
            // modifiedDateLabel
            // 
            this.modifiedDateLabel.AutoSize = true;
            this.modifiedDateLabel.Location = new System.Drawing.Point(376, 177);
            this.modifiedDateLabel.Name = "modifiedDateLabel";
            this.modifiedDateLabel.Size = new System.Drawing.Size(50, 13);
            this.modifiedDateLabel.TabIndex = 19;
            this.modifiedDateLabel.Text = "Modified:";
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(225, 218);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(39, 23);
            this.moveFirstButton.TabIndex = 21;
            this.moveFirstButton.Text = "|<";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.Location = new System.Drawing.Point(270, 218);
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.Size = new System.Drawing.Size(39, 23);
            this.movePreviousButton.TabIndex = 22;
            this.movePreviousButton.Text = "<";
            this.movePreviousButton.UseVisualStyleBackColor = true;
            this.movePreviousButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPositionLabel.Location = new System.Drawing.Point(315, 218);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(86, 23);
            this.currentPositionLabel.TabIndex = 23;
            this.currentPositionLabel.Text = "000 of 000";
            this.currentPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveNextButton
            // 
            this.moveNextButton.Location = new System.Drawing.Point(407, 218);
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.Size = new System.Drawing.Size(39, 23);
            this.moveNextButton.TabIndex = 24;
            this.moveNextButton.Text = ">";
            this.moveNextButton.UseVisualStyleBackColor = true;
            this.moveNextButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(452, 218);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(39, 23);
            this.moveLastButton.TabIndex = 25;
            this.moveLastButton.Text = ">|";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(201, 244);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 23);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(281, 244);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 23);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(360, 244);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 23);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(441, 244);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(74, 23);
            this.newButton.TabIndex = 29;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // creditRatingComboBox
            // 
            this.creditRatingComboBox.FormattingEnabled = true;
            this.creditRatingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.creditRatingComboBox.Location = new System.Drawing.Point(461, 98);
            this.creditRatingComboBox.Name = "creditRatingComboBox";
            this.creditRatingComboBox.Size = new System.Drawing.Size(54, 21);
            this.creditRatingComboBox.TabIndex = 16;
            this.creditRatingComboBox.SelectedValueChanged += new System.EventHandler(this.controlValueChanged);
            // 
            // adventureWorksDataSet1
            // 
            this.adventureWorksDataSet1.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.adventureWorksDataSet1;
            // 
            // vendorTableAdapter1
            // 
            this.vendorTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 330);
            this.Controls.Add(this.creditRatingComboBox);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moveLastButton);
            this.Controls.Add(this.moveNextButton);
            this.Controls.Add(this.currentPositionLabel);
            this.Controls.Add(this.movePreviousButton);
            this.Controls.Add(this.moveFirstButton);
            this.Controls.Add(this.modifiedDateLabel);
            this.Controls.Add(this.creditRatingLabel);
            this.Controls.Add(this.acctNumberLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityStateLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.entityIDLabel);
            this.Controls.Add(this.addressModifiedDateTimePicker);
            this.Controls.Add(this.vendorActiveCheckBox);
            this.Controls.Add(this.preferredVendorCheckBox);
            this.Controls.Add(this.acctNumberTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(this.businessEntityIDLabel);
            this.Name = "Form1";
            this.Text = "Dbenson2747 Exercise 2A: Unbound Controls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label businessEntityIDLabel;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox acctNumberTextBox;
        private System.Windows.Forms.CheckBox preferredVendorCheckBox;
        private System.Windows.Forms.CheckBox vendorActiveCheckBox;
        private System.Windows.Forms.DateTimePicker addressModifiedDateTimePicker;
        private System.Windows.Forms.Label entityIDLabel;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label cityStateLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label acctNumberLabel;
        private System.Windows.Forms.Label creditRatingLabel;
        private System.Windows.Forms.Label modifiedDateLabel;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ComboBox creditRatingComboBox;
        private AdventureWorksDataSet adventureWorksDataSet1;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTableAdapter1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

