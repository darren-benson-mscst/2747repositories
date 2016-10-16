namespace dbenson2747SeniorCitizenProj1k
{
    partial class Form1ex1k
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
            System.Windows.Forms.Label empFirstNameLabel;
            System.Windows.Forms.Label clientAddressLabel;
            System.Windows.Forms.Label serviceDescriptionLabel;
            System.Windows.Forms.Label serviceRateHourlyLabel;
            System.Windows.Forms.Label serviceRateDailyLabel;
            System.Windows.Forms.Label serviceRateWeeklyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1ex1k));
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seniorCitizenProj2722DataSet = new dbenson2747SeniorCitizenProj1k.SeniorCitizenProj2722DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeIDLabel1 = new System.Windows.Forms.Label();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeTableAdapter = new dbenson2747SeniorCitizenProj1k.SeniorCitizenProj2722DataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new dbenson2747SeniorCitizenProj1k.SeniorCitizenProj2722DataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new dbenson2747SeniorCitizenProj1k.SeniorCitizenProj2722DataSetTableAdapters.ClientTableAdapter();
            this.residenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.residenceTableAdapter = new dbenson2747SeniorCitizenProj1k.SeniorCitizenProj2722DataSetTableAdapters.ResidenceTableAdapter();
            this.clientAddressComboBox = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new dbenson2747SeniorCitizenProj1k.SeniorCitizenProj2722DataSetTableAdapters.ServiceTableAdapter();
            this.serviceRateHourlyTextBox = new System.Windows.Forms.TextBox();
            this.serviceRateDailyTextBox = new System.Windows.Forms.TextBox();
            this.serviceRateWeeklyTextBox = new System.Windows.Forms.TextBox();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.hourlyCheckBox = new System.Windows.Forms.CheckBox();
            this.dailyCheckBox = new System.Windows.Forms.CheckBox();
            this.weeklyCheckBox = new System.Windows.Forms.CheckBox();
            employeeIDLabel = new System.Windows.Forms.Label();
            empFirstNameLabel = new System.Windows.Forms.Label();
            clientAddressLabel = new System.Windows.Forms.Label();
            serviceDescriptionLabel = new System.Windows.Forms.Label();
            serviceRateHourlyLabel = new System.Windows.Forms.Label();
            serviceRateDailyLabel = new System.Windows.Forms.Label();
            serviceRateWeeklyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorCitizenProj2722DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(21, 44);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 1;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // empFirstNameLabel
            // 
            empFirstNameLabel.AutoSize = true;
            empFirstNameLabel.Location = new System.Drawing.Point(21, 76);
            empFirstNameLabel.Name = "empFirstNameLabel";
            empFirstNameLabel.Size = new System.Drawing.Size(87, 13);
            empFirstNameLabel.TabIndex = 3;
            empFirstNameLabel.Text = "Employee Name:";
            // 
            // clientAddressLabel
            // 
            clientAddressLabel.AutoSize = true;
            clientAddressLabel.Location = new System.Drawing.Point(21, 284);
            clientAddressLabel.Name = "clientAddressLabel";
            clientAddressLabel.Size = new System.Drawing.Size(77, 13);
            clientAddressLabel.TabIndex = 7;
            clientAddressLabel.Text = "Client Address:";
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.AutoSize = true;
            serviceDescriptionLabel.Location = new System.Drawing.Point(21, 340);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new System.Drawing.Size(46, 13);
            serviceDescriptionLabel.TabIndex = 12;
            serviceDescriptionLabel.Text = "Service:";
            // 
            // serviceRateHourlyLabel
            // 
            serviceRateHourlyLabel.AutoSize = true;
            serviceRateHourlyLabel.Location = new System.Drawing.Point(21, 375);
            serviceRateHourlyLabel.Name = "serviceRateHourlyLabel";
            serviceRateHourlyLabel.Size = new System.Drawing.Size(66, 13);
            serviceRateHourlyLabel.TabIndex = 14;
            serviceRateHourlyLabel.Text = "Hourly Rate:";
            // 
            // serviceRateDailyLabel
            // 
            serviceRateDailyLabel.AutoSize = true;
            serviceRateDailyLabel.Location = new System.Drawing.Point(21, 407);
            serviceRateDailyLabel.Name = "serviceRateDailyLabel";
            serviceRateDailyLabel.Size = new System.Drawing.Size(59, 13);
            serviceRateDailyLabel.TabIndex = 16;
            serviceRateDailyLabel.Text = "Daily Rate:";
            // 
            // serviceRateWeeklyLabel
            // 
            serviceRateWeeklyLabel.AutoSize = true;
            serviceRateWeeklyLabel.Location = new System.Drawing.Point(21, 440);
            serviceRateWeeklyLabel.Name = "serviceRateWeeklyLabel";
            serviceRateWeeklyLabel.Size = new System.Drawing.Size(72, 13);
            serviceRateWeeklyLabel.TabIndex = 18;
            serviceRateWeeklyLabel.Text = "Weekly Rate:";
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(719, 25);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.seniorCitizenProj2722DataSet;
            // 
            // seniorCitizenProj2722DataSet
            // 
            this.seniorCitizenProj2722DataSet.DataSetName = "SeniorCitizenProj2722DataSet";
            this.seniorCitizenProj2722DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // employeeIDLabel1
            // 
            this.employeeIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeID", true));
            this.employeeIDLabel1.Location = new System.Drawing.Point(112, 44);
            this.employeeIDLabel1.Name = "employeeIDLabel1";
            this.employeeIDLabel1.Size = new System.Drawing.Size(55, 23);
            this.employeeIDLabel1.TabIndex = 2;
            this.employeeIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(24, 121);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(477, 134);
            this.clientDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientFirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClientLastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClientAge";
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClientDateOfBirth";
            this.dataGridViewTextBoxColumn5.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.seniorCitizenProj2722DataSet;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DataSource = this.employeeBindingSource;
            this.employeeComboBox.DisplayMember = "EmployeeName";
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(112, 73);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeComboBox.TabIndex = 7;
            this.employeeComboBox.ValueMember = "EmployeeID";
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
            this.tableAdapterManager.ResidenceTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbenson2747SeniorCitizenProj1k.SeniorCitizenProj2722DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // residenceBindingSource
            // 
            this.residenceBindingSource.DataMember = "Residence";
            this.residenceBindingSource.DataSource = this.seniorCitizenProj2722DataSet;
            // 
            // residenceTableAdapter
            // 
            this.residenceTableAdapter.ClearBeforeFill = true;
            // 
            // clientAddressComboBox
            // 
            this.clientAddressComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.residenceBindingSource, "ClientAddress", true));
            this.clientAddressComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "ClientID", true));
            this.clientAddressComboBox.DataSource = this.residenceBindingSource;
            this.clientAddressComboBox.DisplayMember = "ClientAddress";
            this.clientAddressComboBox.FormattingEnabled = true;
            this.clientAddressComboBox.Location = new System.Drawing.Point(102, 281);
            this.clientAddressComboBox.Name = "clientAddressComboBox";
            this.clientAddressComboBox.Size = new System.Drawing.Size(224, 21);
            this.clientAddressComboBox.TabIndex = 10;
            this.clientAddressComboBox.ValueMember = "ResidenceID";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.seniorCitizenProj2722DataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // serviceRateHourlyTextBox
            // 
            this.serviceRateHourlyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceRateHourly", true));
            this.serviceRateHourlyTextBox.Location = new System.Drawing.Point(138, 372);
            this.serviceRateHourlyTextBox.Name = "serviceRateHourlyTextBox";
            this.serviceRateHourlyTextBox.Size = new System.Drawing.Size(73, 20);
            this.serviceRateHourlyTextBox.TabIndex = 15;
            // 
            // serviceRateDailyTextBox
            // 
            this.serviceRateDailyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceRateDaily", true));
            this.serviceRateDailyTextBox.Location = new System.Drawing.Point(138, 404);
            this.serviceRateDailyTextBox.Name = "serviceRateDailyTextBox";
            this.serviceRateDailyTextBox.Size = new System.Drawing.Size(73, 20);
            this.serviceRateDailyTextBox.TabIndex = 17;
            // 
            // serviceRateWeeklyTextBox
            // 
            this.serviceRateWeeklyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceRateWeekly", true));
            this.serviceRateWeeklyTextBox.Location = new System.Drawing.Point(138, 437);
            this.serviceRateWeeklyTextBox.Name = "serviceRateWeeklyTextBox";
            this.serviceRateWeeklyTextBox.Size = new System.Drawing.Size(73, 20);
            this.serviceRateWeeklyTextBox.TabIndex = 19;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DataSource = this.serviceBindingSource;
            this.serviceComboBox.DisplayMember = "ServiceDescription";
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(138, 340);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(126, 21);
            this.serviceComboBox.TabIndex = 20;
            this.serviceComboBox.ValueMember = "ServiceID";
            // 
            // hourlyCheckBox
            // 
            this.hourlyCheckBox.AutoSize = true;
            this.hourlyCheckBox.Location = new System.Drawing.Point(229, 375);
            this.hourlyCheckBox.Name = "hourlyCheckBox";
            this.hourlyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hourlyCheckBox.TabIndex = 21;
            this.hourlyCheckBox.UseVisualStyleBackColor = true;
            //this.hourlyCheckBox.CheckStateChanged += new System.EventHandler(this.hourlyCheckBox_CheckStateChanged);
            // 
            // dailyCheckBox
            // 
            this.dailyCheckBox.AutoSize = true;
            this.dailyCheckBox.Location = new System.Drawing.Point(229, 406);
            this.dailyCheckBox.Name = "dailyCheckBox";
            this.dailyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dailyCheckBox.TabIndex = 22;
            this.dailyCheckBox.UseVisualStyleBackColor = true;
            //this.dailyCheckBox.CheckStateChanged += new System.EventHandler(this.dailyCheckBox_CheckStateChanged);
            // 
            // weeklyCheckBox
            // 
            this.weeklyCheckBox.AutoSize = true;
            this.weeklyCheckBox.Location = new System.Drawing.Point(229, 439);
            this.weeklyCheckBox.Name = "weeklyCheckBox";
            this.weeklyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.weeklyCheckBox.TabIndex = 23;
            this.weeklyCheckBox.UseVisualStyleBackColor = true;
            //this.weeklyCheckBox.CheckedChanged += new System.EventHandler(this.weeklyCheckBox_CheckedChanged);
            // 
            // Form1ex1k
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 517);
            this.Controls.Add(this.weeklyCheckBox);
            this.Controls.Add(this.dailyCheckBox);
            this.Controls.Add(this.hourlyCheckBox);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(serviceDescriptionLabel);
            this.Controls.Add(serviceRateHourlyLabel);
            this.Controls.Add(this.serviceRateHourlyTextBox);
            this.Controls.Add(serviceRateDailyLabel);
            this.Controls.Add(this.serviceRateDailyTextBox);
            this.Controls.Add(serviceRateWeeklyLabel);
            this.Controls.Add(this.serviceRateWeeklyTextBox);
            this.Controls.Add(clientAddressLabel);
            this.Controls.Add(this.clientAddressComboBox);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDLabel1);
            this.Controls.Add(empFirstNameLabel);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Name = "Form1ex1k";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1ex1k_FormClosing);
            this.Load += new System.EventHandler(this.Form1ex1k_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorCitizenProj2722DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeniorCitizenProj2722DataSet seniorCitizenProj2722DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private SeniorCitizenProj2722DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private SeniorCitizenProj2722DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.Label employeeIDLabel1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SeniorCitizenProj2722DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.BindingSource residenceBindingSource;
        private SeniorCitizenProj2722DataSetTableAdapters.ResidenceTableAdapter residenceTableAdapter;
        private System.Windows.Forms.ComboBox clientAddressComboBox;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private SeniorCitizenProj2722DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.TextBox serviceRateHourlyTextBox;
        private System.Windows.Forms.TextBox serviceRateDailyTextBox;
        private System.Windows.Forms.TextBox serviceRateWeeklyTextBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.CheckBox hourlyCheckBox;
        private System.Windows.Forms.CheckBox dailyCheckBox;
        private System.Windows.Forms.CheckBox weeklyCheckBox;
    }
}

