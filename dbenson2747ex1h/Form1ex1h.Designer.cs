namespace dbenson2747ex1h
{
    partial class Form1ex1h
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
            System.Windows.Forms.Label purchaseOrderIDLabel;
            System.Windows.Forms.Label revisionNumberLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label shipMethodIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label taxAmtLabel;
            System.Windows.Forms.Label freightLabel;
            System.Windows.Forms.Label totalDueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1ex1h));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adventureWorksDataSet = new dbenson2747ex1h.AdventureWorksDataSet();
            this.purchaseOrderHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderHeaderTableAdapter = new dbenson2747ex1h.AdventureWorksDataSetTableAdapters.PurchaseOrderHeaderTableAdapter();
            this.tableAdapterManager = new dbenson2747ex1h.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.employeeNameTableAdapter = new dbenson2747ex1h.AdventureWorksDataSetTableAdapters.EmployeeNameTableAdapter();
            this.purchaseOrderDetailTableAdapter = new dbenson2747ex1h.AdventureWorksDataSetTableAdapters.PurchaseOrderDetailTableAdapter();
            this.shipMethodTableAdapter = new dbenson2747ex1h.AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter();
            this.vendorTableAdapter = new dbenson2747ex1h.AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            this.purchaseOrderHeaderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.purchaseOrderHeaderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseOrderIDLabel1 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subTotalLabel1 = new System.Windows.Forms.Label();
            this.taxAmtLabel1 = new System.Windows.Forms.Label();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.totalDueLabel1 = new System.Windows.Forms.Label();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.employeeNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.shipMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.vendorCountLabel = new System.Windows.Forms.Label();
            this.vendorsGroupBox = new System.Windows.Forms.GroupBox();
            this.loadAllButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.cityButton = new System.Windows.Forms.Button();
            this.stateButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.totalOrdersLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstDateLabel = new System.Windows.Forms.Label();
            this.revNumberLabel = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new dbenson2747ex1h.AdventureWorksDataSetTableAdapters.ProductTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcLineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            purchaseOrderIDLabel = new System.Windows.Forms.Label();
            revisionNumberLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            vendorIDLabel = new System.Windows.Forms.Label();
            shipMethodIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            taxAmtLabel = new System.Windows.Forms.Label();
            freightLabel = new System.Windows.Forms.Label();
            totalDueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingNavigator)).BeginInit();
            this.purchaseOrderHeaderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).BeginInit();
            this.vendorsGroupBox.SuspendLayout();
            this.dateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderIDLabel
            // 
            purchaseOrderIDLabel.AutoSize = true;
            purchaseOrderIDLabel.Location = new System.Drawing.Point(22, 133);
            purchaseOrderIDLabel.Name = "purchaseOrderIDLabel";
            purchaseOrderIDLabel.Size = new System.Drawing.Size(98, 13);
            purchaseOrderIDLabel.TabIndex = 1;
            purchaseOrderIDLabel.Text = "Purchase Order ID:";
            // 
            // revisionNumberLabel
            // 
            revisionNumberLabel.AutoSize = true;
            revisionNumberLabel.Location = new System.Drawing.Point(208, 133);
            revisionNumberLabel.Name = "revisionNumberLabel";
            revisionNumberLabel.Size = new System.Drawing.Size(91, 13);
            revisionNumberLabel.TabIndex = 3;
            revisionNumberLabel.Text = "Revision Number:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(400, 133);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(22, 167);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 7;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(14, 67);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            vendorIDLabel.TabIndex = 9;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // shipMethodIDLabel
            // 
            shipMethodIDLabel.AutoSize = true;
            shipMethodIDLabel.Location = new System.Drawing.Point(22, 314);
            shipMethodIDLabel.Name = "shipMethodIDLabel";
            shipMethodIDLabel.Size = new System.Drawing.Size(84, 13);
            shipMethodIDLabel.TabIndex = 11;
            shipMethodIDLabel.Text = "Ship Method ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(22, 286);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 13;
            orderDateLabel.Text = "Order Date:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(22, 505);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 17;
            subTotalLabel.Text = "Sub Total:";
            // 
            // taxAmtLabel
            // 
            taxAmtLabel.AutoSize = true;
            taxAmtLabel.Location = new System.Drawing.Point(24, 537);
            taxAmtLabel.Name = "taxAmtLabel";
            taxAmtLabel.Size = new System.Drawing.Size(49, 13);
            taxAmtLabel.TabIndex = 19;
            taxAmtLabel.Text = "Tax Amt:";
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(24, 568);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(42, 13);
            freightLabel.TabIndex = 21;
            freightLabel.Text = "Freight:";
            // 
            // totalDueLabel
            // 
            totalDueLabel.AutoSize = true;
            totalDueLabel.Location = new System.Drawing.Point(22, 606);
            totalDueLabel.Name = "totalDueLabel";
            totalDueLabel.Size = new System.Drawing.Size(57, 13);
            totalDueLabel.TabIndex = 23;
            totalDueLabel.Text = "Total Due:";
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrderHeaderBindingSource
            // 
            this.purchaseOrderHeaderBindingSource.DataMember = "PurchaseOrderHeader";
            this.purchaseOrderHeaderBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // purchaseOrderHeaderTableAdapter
            // 
            this.purchaseOrderHeaderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeNameTableAdapter = this.employeeNameTableAdapter;
            this.tableAdapterManager.PurchaseOrderDetailTableAdapter = this.purchaseOrderDetailTableAdapter;
            this.tableAdapterManager.PurchaseOrderHeaderTableAdapter = this.purchaseOrderHeaderTableAdapter;
            this.tableAdapterManager.ShipMethodTableAdapter = this.shipMethodTableAdapter;
            this.tableAdapterManager.UpdateOrder = dbenson2747ex1h.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = this.vendorTableAdapter;
            // 
            // employeeNameTableAdapter
            // 
            this.employeeNameTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderDetailTableAdapter
            // 
            this.purchaseOrderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // shipMethodTableAdapter
            // 
            this.shipMethodTableAdapter.ClearBeforeFill = true;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderHeaderBindingNavigator
            // 
            this.purchaseOrderHeaderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseOrderHeaderBindingNavigator.BindingSource = this.purchaseOrderHeaderBindingSource;
            this.purchaseOrderHeaderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseOrderHeaderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseOrderHeaderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseOrderHeaderBindingNavigatorSaveItem});
            this.purchaseOrderHeaderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderHeaderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseOrderHeaderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseOrderHeaderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseOrderHeaderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseOrderHeaderBindingNavigator.Name = "purchaseOrderHeaderBindingNavigator";
            this.purchaseOrderHeaderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseOrderHeaderBindingNavigator.Size = new System.Drawing.Size(1002, 25);
            this.purchaseOrderHeaderBindingNavigator.TabIndex = 0;
            this.purchaseOrderHeaderBindingNavigator.Text = "bindingNavigator1";
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
            // purchaseOrderHeaderBindingNavigatorSaveItem
            // 
            this.purchaseOrderHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseOrderHeaderBindingNavigatorSaveItem.Image")));
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Name = "purchaseOrderHeaderBindingNavigatorSaveItem";
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // purchaseOrderIDLabel1
            // 
            this.purchaseOrderIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchaseOrderIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "PurchaseOrderID", true));
            this.purchaseOrderIDLabel1.Location = new System.Drawing.Point(129, 128);
            this.purchaseOrderIDLabel1.Name = "purchaseOrderIDLabel1";
            this.purchaseOrderIDLabel1.Size = new System.Drawing.Size(67, 23);
            this.purchaseOrderIDLabel1.TabIndex = 2;
            this.purchaseOrderIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(446, 130);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(47, 20);
            this.statusTextBox.TabIndex = 6;
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(129, 283);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(223, 20);
            this.orderDateDateTimePicker.TabIndex = 14;
            // 
            // shipDateDateTimePicker
            // 
            this.shipDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "ShipDate", true));
            this.shipDateDateTimePicker.Location = new System.Drawing.Point(305, 309);
            this.shipDateDateTimePicker.Name = "shipDateDateTimePicker";
            this.shipDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipDateDateTimePicker.TabIndex = 16;
            // 
            // subTotalLabel1
            // 
            this.subTotalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalLabel1.Location = new System.Drawing.Point(106, 500);
            this.subTotalLabel1.Name = "subTotalLabel1";
            this.subTotalLabel1.Size = new System.Drawing.Size(90, 23);
            this.subTotalLabel1.TabIndex = 18;
            this.subTotalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxAmtLabel1
            // 
            this.taxAmtLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmtLabel1.Location = new System.Drawing.Point(106, 532);
            this.taxAmtLabel1.Name = "taxAmtLabel1";
            this.taxAmtLabel1.Size = new System.Drawing.Size(90, 23);
            this.taxAmtLabel1.TabIndex = 20;
            this.taxAmtLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Freight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.freightTextBox.Location = new System.Drawing.Point(106, 568);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(90, 20);
            this.freightTextBox.TabIndex = 22;
            this.freightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalDueLabel1
            // 
            this.totalDueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueLabel1.Location = new System.Drawing.Point(106, 601);
            this.totalDueLabel1.Name = "totalDueLabel1";
            this.totalDueLabel1.Size = new System.Drawing.Size(90, 23);
            this.totalDueLabel1.TabIndex = 24;
            this.totalDueLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalDueLabel1.Click += new System.EventHandler(this.totalDueLabel1_Click);
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.DataSource = this.vendorBindingSource;
            this.vendorComboBox.DisplayMember = "Name";
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.Location = new System.Drawing.Point(121, 64);
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(203, 21);
            this.vendorComboBox.TabIndex = 25;
            this.vendorComboBox.ValueMember = "BusinessEntityID";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "EmployeeID", true));
            this.comboBox2.DataSource = this.employeeNameBindingSource;
            this.comboBox2.DisplayMember = "LastFirstName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "BusinessEntityID";
            // 
            // employeeNameBindingSource
            // 
            this.employeeNameBindingSource.DataMember = "EmployeeName";
            this.employeeNameBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "ShipMethodID", true));
            this.comboBox3.DataSource = this.shipMethodBindingSource;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(129, 309);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(170, 21);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.ValueMember = "ShipMethodID";
            // 
            // shipMethodBindingSource
            // 
            this.shipMethodBindingSource.DataMember = "ShipMethod";
            this.shipMethodBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // purchaseOrderDetailBindingSource
            // 
            this.purchaseOrderDetailBindingSource.DataMember = "PurchaseOrderDetail";
            this.purchaseOrderDetailBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // purchaseOrderDetailDataGridView
            // 
            this.purchaseOrderDetailDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Product,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.calcLineTotal,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.purchaseOrderDetailDataGridView.DataSource = this.purchaseOrderDetailBindingSource;
            this.purchaseOrderDetailDataGridView.Location = new System.Drawing.Point(25, 342);
            this.purchaseOrderDetailDataGridView.Name = "purchaseOrderDetailDataGridView";
            this.purchaseOrderDetailDataGridView.Size = new System.Drawing.Size(878, 139);
            this.purchaseOrderDetailDataGridView.TabIndex = 27;
            this.purchaseOrderDetailDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.purchaseOrderDetailDataGridView_UserAddedRow);
            // 
            // vendorCountLabel
            // 
            this.vendorCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorCountLabel.Location = new System.Drawing.Point(339, 62);
            this.vendorCountLabel.Name = "vendorCountLabel";
            this.vendorCountLabel.Size = new System.Drawing.Size(243, 23);
            this.vendorCountLabel.TabIndex = 28;
            // 
            // vendorsGroupBox
            // 
            this.vendorsGroupBox.Controls.Add(this.loadAllButton);
            this.vendorsGroupBox.Controls.Add(this.nameButton);
            this.vendorsGroupBox.Controls.Add(this.cityButton);
            this.vendorsGroupBox.Controls.Add(this.stateButton);
            this.vendorsGroupBox.Controls.Add(this.searchTextBox);
            this.vendorsGroupBox.Controls.Add(this.filterLabel);
            this.vendorsGroupBox.Controls.Add(this.vendorComboBox);
            this.vendorsGroupBox.Controls.Add(this.vendorCountLabel);
            this.vendorsGroupBox.Controls.Add(vendorIDLabel);
            this.vendorsGroupBox.Location = new System.Drawing.Point(12, 28);
            this.vendorsGroupBox.Name = "vendorsGroupBox";
            this.vendorsGroupBox.Size = new System.Drawing.Size(652, 97);
            this.vendorsGroupBox.TabIndex = 29;
            this.vendorsGroupBox.TabStop = false;
            this.vendorsGroupBox.Text = "Select Vendors:";
            // 
            // loadAllButton
            // 
            this.loadAllButton.Location = new System.Drawing.Point(532, 26);
            this.loadAllButton.Name = "loadAllButton";
            this.loadAllButton.Size = new System.Drawing.Size(99, 23);
            this.loadAllButton.TabIndex = 34;
            this.loadAllButton.Text = "Load All";
            this.loadAllButton.UseVisualStyleBackColor = true;
            this.loadAllButton.Click += new System.EventHandler(this.loadAllButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(435, 26);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(91, 23);
            this.nameButton.TabIndex = 33;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // cityButton
            // 
            this.cityButton.Location = new System.Drawing.Point(339, 26);
            this.cityButton.Name = "cityButton";
            this.cityButton.Size = new System.Drawing.Size(89, 23);
            this.cityButton.TabIndex = 32;
            this.cityButton.Text = "City";
            this.cityButton.UseVisualStyleBackColor = true;
            this.cityButton.Click += new System.EventHandler(this.cityButton_Click);
            // 
            // stateButton
            // 
            this.stateButton.Location = new System.Drawing.Point(240, 26);
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(93, 23);
            this.stateButton.TabIndex = 31;
            this.stateButton.Text = "State";
            this.stateButton.UseVisualStyleBackColor = true;
            this.stateButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(121, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(113, 20);
            this.searchTextBox.TabIndex = 30;
            this.searchTextBox.Text = "Bur";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(14, 28);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(32, 13);
            this.filterLabel.TabIndex = 29;
            this.filterLabel.Text = "Filter:";
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.totalOrdersLabel);
            this.dateGroupBox.Controls.Add(this.endDateTimePicker);
            this.dateGroupBox.Controls.Add(this.lastDateLabel);
            this.dateGroupBox.Controls.Add(this.startDateTimePicker);
            this.dateGroupBox.Controls.Add(this.firstDateLabel);
            this.dateGroupBox.Location = new System.Drawing.Point(12, 201);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(639, 79);
            this.dateGroupBox.TabIndex = 30;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Select Orders By Date:";
            // 
            // totalOrdersLabel
            // 
            this.totalOrdersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOrdersLabel.Location = new System.Drawing.Point(435, 38);
            this.totalOrdersLabel.Name = "totalOrdersLabel";
            this.totalOrdersLabel.Size = new System.Drawing.Size(185, 23);
            this.totalOrdersLabel.TabIndex = 4;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(312, 38);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // lastDateLabel
            // 
            this.lastDateLabel.AutoSize = true;
            this.lastDateLabel.Location = new System.Drawing.Point(247, 38);
            this.lastDateLabel.Name = "lastDateLabel";
            this.lastDateLabel.Size = new System.Drawing.Size(59, 13);
            this.lastDateLabel.TabIndex = 2;
            this.lastDateLabel.Text = "Last Date: ";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(119, 38);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // firstDateLabel
            // 
            this.firstDateLabel.AutoSize = true;
            this.firstDateLabel.Location = new System.Drawing.Point(14, 38);
            this.firstDateLabel.Name = "firstDateLabel";
            this.firstDateLabel.Size = new System.Drawing.Size(55, 13);
            this.firstDateLabel.TabIndex = 0;
            this.firstDateLabel.Text = "First Date:";
            // 
            // revNumberLabel
            // 
            this.revNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revNumberLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "RevisionNumber", true));
            this.revNumberLabel.Location = new System.Drawing.Point(315, 130);
            this.revNumberLabel.Name = "revNumberLabel";
            this.revNumberLabel.Size = new System.Drawing.Size(67, 23);
            this.revNumberLabel.TabIndex = 31;
            this.revNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseOrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PurchaseOrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PurchaseOrderDetailID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "PODetailID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderQty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderQty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "ProductID";
            this.Product.DataSource = this.productBindingSource;
            this.Product.DisplayMember = "SubcatProductName";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ValueMember = "ProductID";
            this.Product.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LineTotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "LineTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // calcLineTotal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.calcLineTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.calcLineTotal.HeaderText = "LineTotal";
            this.calcLineTotal.Name = "calcLineTotal";
            this.calcLineTotal.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReceivedQty";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn8.HeaderText = "Rec";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RejectedQty";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn9.HeaderText = "Rej";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "StockedQty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn10.HeaderText = "StockedQty";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // Form1ex1h
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 656);
            this.Controls.Add(this.revNumberLabel);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.vendorsGroupBox);
            this.Controls.Add(this.purchaseOrderDetailDataGridView);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(purchaseOrderIDLabel);
            this.Controls.Add(this.purchaseOrderIDLabel1);
            this.Controls.Add(revisionNumberLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(shipMethodIDLabel);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(this.shipDateDateTimePicker);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalLabel1);
            this.Controls.Add(taxAmtLabel);
            this.Controls.Add(this.taxAmtLabel1);
            this.Controls.Add(freightLabel);
            this.Controls.Add(this.freightTextBox);
            this.Controls.Add(totalDueLabel);
            this.Controls.Add(this.totalDueLabel1);
            this.Controls.Add(this.purchaseOrderHeaderBindingNavigator);
            this.Name = "Form1ex1h";
            this.Text = "dbenson2747ex1h";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1ex1h_FormClosing);
            this.Load += new System.EventHandler(this.Form1ex1h_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingNavigator)).EndInit();
            this.purchaseOrderHeaderBindingNavigator.ResumeLayout(false);
            this.purchaseOrderHeaderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).EndInit();
            this.vendorsGroupBox.ResumeLayout(false);
            this.vendorsGroupBox.PerformLayout();
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource purchaseOrderHeaderBindingSource;
        private AdventureWorksDataSetTableAdapters.PurchaseOrderHeaderTableAdapter purchaseOrderHeaderTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseOrderHeaderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseOrderHeaderBindingNavigatorSaveItem;
        private System.Windows.Forms.Label purchaseOrderIDLabel1;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipDateDateTimePicker;
        private System.Windows.Forms.Label subTotalLabel1;
        private System.Windows.Forms.Label taxAmtLabel1;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.Label totalDueLabel1;
        private System.Windows.Forms.ComboBox vendorComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private AdventureWorksDataSetTableAdapters.PurchaseOrderDetailTableAdapter purchaseOrderDetailTableAdapter;
        private System.Windows.Forms.BindingSource purchaseOrderDetailBindingSource;
        private System.Windows.Forms.DataGridView purchaseOrderDetailDataGridView;
        private AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private AdventureWorksDataSetTableAdapters.EmployeeNameTableAdapter employeeNameTableAdapter;
        private System.Windows.Forms.BindingSource employeeNameBindingSource;
        private AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter shipMethodTableAdapter;
        private System.Windows.Forms.BindingSource shipMethodBindingSource;
        private System.Windows.Forms.Label vendorCountLabel;
        private System.Windows.Forms.GroupBox vendorsGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button loadAllButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Button stateButton;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label lastDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label firstDateLabel;
        private System.Windows.Forms.Label totalOrdersLabel;
        private System.Windows.Forms.Label revNumberLabel;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AdventureWorksDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcLineTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

