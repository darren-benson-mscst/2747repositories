namespace dbenson2747ex1e
{
    partial class MasterDetailForm
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
            System.Windows.Forms.Label shipMethodIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label taxAmtLabel;
            System.Windows.Forms.Label freightLabel;
            System.Windows.Forms.Label totalDueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetailForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adventureWorksDataSet = new dbenson2747ex1e.AdventureWorksDataSet();
            this.purchaseOrderHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderHeaderTableAdapter = new dbenson2747ex1e.AdventureWorksDataSetTableAdapters.PurchaseOrderHeaderTableAdapter();
            this.tableAdapterManager = new dbenson2747ex1e.AdventureWorksDataSetTableAdapters.TableAdapterManager();
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
            this.revisionNumberTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subTotalLabel1 = new System.Windows.Forms.Label();
            this.taxAmtLabel1 = new System.Windows.Forms.Label();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.totalDueLabel1 = new System.Windows.Forms.Label();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new dbenson2747ex1e.AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.purchaseOrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderDetailTableAdapter = new dbenson2747ex1e.AdventureWorksDataSetTableAdapters.PurchaseOrderDetailTableAdapter();
            this.purchaseOrderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.shipMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipMethodTableAdapter = new dbenson2747ex1e.AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter();
            this.shipperNameComboBox = new System.Windows.Forms.ComboBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeNameTableAdapter = new dbenson2747ex1e.AdventureWorksDataSetTableAdapters.EmployeeNameTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.subTotalGridViewLabel = new System.Windows.Forms.Label();
            this.taxGridViewLabel = new System.Windows.Forms.Label();
            this.totalGridViewLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subTotalBindingSourceLabel = new System.Windows.Forms.Label();
            this.taxBindingSourceLabel = new System.Windows.Forms.Label();
            this.totalBindingSourceLabel = new System.Windows.Forms.Label();
            this.bindingSourceLabel = new System.Windows.Forms.Label();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.rowColumnIndexLabel = new System.Windows.Forms.Label();
            this.detailIDLabel = new System.Windows.Forms.Label();
            this.currentCellValLabel = new System.Windows.Forms.Label();
            this.rowCountBox = new System.Windows.Forms.Label();
            this.rowIndexBox = new System.Windows.Forms.Label();
            this.detailIDBox = new System.Windows.Forms.Label();
            this.currentCellValBox = new System.Windows.Forms.Label();
            this.colIndexBox = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showForm1Button = new System.Windows.Forms.Button();
            purchaseOrderIDLabel = new System.Windows.Forms.Label();
            revisionNumberLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderIDLabel
            // 
            purchaseOrderIDLabel.AutoSize = true;
            purchaseOrderIDLabel.Location = new System.Drawing.Point(12, 63);
            purchaseOrderIDLabel.Name = "purchaseOrderIDLabel";
            purchaseOrderIDLabel.Size = new System.Drawing.Size(98, 13);
            purchaseOrderIDLabel.TabIndex = 1;
            purchaseOrderIDLabel.Text = "Purchase Order ID:";
            // 
            // revisionNumberLabel
            // 
            revisionNumberLabel.AutoSize = true;
            revisionNumberLabel.Location = new System.Drawing.Point(12, 92);
            revisionNumberLabel.Name = "revisionNumberLabel";
            revisionNumberLabel.Size = new System.Drawing.Size(91, 13);
            revisionNumberLabel.TabIndex = 3;
            revisionNumberLabel.Text = "Revision Number:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(182, 92);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(12, 122);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(70, 13);
            employeeIDLabel.TabIndex = 7;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // shipMethodIDLabel
            // 
            shipMethodIDLabel.AutoSize = true;
            shipMethodIDLabel.Location = new System.Drawing.Point(12, 180);
            shipMethodIDLabel.Name = "shipMethodIDLabel";
            shipMethodIDLabel.Size = new System.Drawing.Size(98, 13);
            shipMethodIDLabel.TabIndex = 11;
            shipMethodIDLabel.Text = "Ship Method/Date:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(12, 152);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 13;
            orderDateLabel.Text = "Order Date:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(12, 397);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(56, 13);
            subTotalLabel.TabIndex = 17;
            subTotalLabel.Text = "Sub Total:";
            // 
            // taxAmtLabel
            // 
            taxAmtLabel.AutoSize = true;
            taxAmtLabel.Location = new System.Drawing.Point(12, 422);
            taxAmtLabel.Name = "taxAmtLabel";
            taxAmtLabel.Size = new System.Drawing.Size(49, 13);
            taxAmtLabel.TabIndex = 19;
            taxAmtLabel.Text = "Tax Amt:";
            // 
            // freightLabel
            // 
            freightLabel.AutoSize = true;
            freightLabel.Location = new System.Drawing.Point(12, 451);
            freightLabel.Name = "freightLabel";
            freightLabel.Size = new System.Drawing.Size(42, 13);
            freightLabel.TabIndex = 21;
            freightLabel.Text = "Freight:";
            // 
            // totalDueLabel
            // 
            totalDueLabel.AutoSize = true;
            totalDueLabel.Location = new System.Drawing.Point(12, 471);
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
            this.purchaseOrderHeaderBindingSource.CurrentChanged += new System.EventHandler(this.purchaseOrderHeaderBindingSource_CurrentChanged);
            // 
            // purchaseOrderHeaderTableAdapter
            // 
            this.purchaseOrderHeaderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeNameTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderDetailTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderHeaderTableAdapter = this.purchaseOrderHeaderTableAdapter;
            this.tableAdapterManager.ShipMethodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbenson2747ex1e.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = null;
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
            this.purchaseOrderHeaderBindingNavigator.Size = new System.Drawing.Size(1016, 25);
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
            this.purchaseOrderHeaderBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseOrderHeaderBindingNavigatorSaveItem_Click);
            // 
            // purchaseOrderIDLabel1
            // 
            this.purchaseOrderIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchaseOrderIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "PurchaseOrderID", true));
            this.purchaseOrderIDLabel1.Location = new System.Drawing.Point(116, 63);
            this.purchaseOrderIDLabel1.Name = "purchaseOrderIDLabel1";
            this.purchaseOrderIDLabel1.Size = new System.Drawing.Size(48, 23);
            this.purchaseOrderIDLabel1.TabIndex = 2;
            this.purchaseOrderIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // revisionNumberTextBox
            // 
            this.revisionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "RevisionNumber", true));
            this.revisionNumberTextBox.Location = new System.Drawing.Point(116, 89);
            this.revisionNumberTextBox.Name = "revisionNumberTextBox";
            this.revisionNumberTextBox.Size = new System.Drawing.Size(48, 20);
            this.revisionNumberTextBox.TabIndex = 4;
            this.revisionNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(243, 89);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(48, 20);
            this.statusTextBox.TabIndex = 6;
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "VendorID", true));
            this.vendorIDTextBox.Location = new System.Drawing.Point(116, 31);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(48, 20);
            this.vendorIDTextBox.TabIndex = 10;
            this.vendorIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(116, 148);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateDateTimePicker.TabIndex = 14;
            // 
            // shipDateDateTimePicker
            // 
            this.shipDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderHeaderBindingSource, "ShipDate", true));
            this.shipDateDateTimePicker.Location = new System.Drawing.Point(243, 178);
            this.shipDateDateTimePicker.Name = "shipDateDateTimePicker";
            this.shipDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipDateDateTimePicker.TabIndex = 16;
            // 
            // subTotalLabel1
            // 
            this.subTotalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "SubTotal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.subTotalLabel1.Location = new System.Drawing.Point(116, 392);
            this.subTotalLabel1.Name = "subTotalLabel1";
            this.subTotalLabel1.Size = new System.Drawing.Size(77, 23);
            this.subTotalLabel1.TabIndex = 18;
            this.subTotalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxAmtLabel1
            // 
            this.taxAmtLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxAmtLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "TaxAmt", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.taxAmtLabel1.Location = new System.Drawing.Point(116, 422);
            this.taxAmtLabel1.Name = "taxAmtLabel1";
            this.taxAmtLabel1.Size = new System.Drawing.Size(77, 23);
            this.taxAmtLabel1.TabIndex = 20;
            this.taxAmtLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // freightTextBox
            // 
            this.freightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "Freight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.freightTextBox.Location = new System.Drawing.Point(116, 448);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(77, 20);
            this.freightTextBox.TabIndex = 22;
            this.freightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalDueLabel1
            // 
            this.totalDueLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderHeaderBindingSource, "TotalDue", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.totalDueLabel1.Location = new System.Drawing.Point(116, 471);
            this.totalDueLabel1.Name = "totalDueLabel1";
            this.totalDueLabel1.Size = new System.Drawing.Size(77, 23);
            this.totalDueLabel1.TabIndex = 24;
            this.totalDueLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.DataSource = this.vendorBindingSource;
            this.vendorComboBox.DisplayMember = "Name";
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.Location = new System.Drawing.Point(185, 31);
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(121, 21);
            this.vendorComboBox.TabIndex = 27;
            this.vendorComboBox.ValueMember = "BusinessEntityID";
            this.vendorComboBox.SelectedValueChanged += new System.EventHandler(this.vendorComboBox_SelectedValueChanged);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Location = new System.Drawing.Point(12, 31);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(44, 13);
            this.vendorLabel.TabIndex = 28;
            this.vendorLabel.Text = "Vendor:";
            // 
            // purchaseOrderDetailBindingSource
            // 
            this.purchaseOrderDetailBindingSource.DataMember = "PurchaseOrderDetail";
            this.purchaseOrderDetailBindingSource.DataSource = this.adventureWorksDataSet;
            this.purchaseOrderDetailBindingSource.CurrentChanged += new System.EventHandler(this.purchaseOrderDetailBindingSource_CurrentChanged);
            // 
            // purchaseOrderDetailTableAdapter
            // 
            this.purchaseOrderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderDetailDataGridView
            // 
            this.purchaseOrderDetailDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.purchaseOrderDetailDataGridView.DataSource = this.purchaseOrderDetailBindingSource;
            this.purchaseOrderDetailDataGridView.Location = new System.Drawing.Point(16, 210);
            this.purchaseOrderDetailDataGridView.Name = "purchaseOrderDetailDataGridView";
            this.purchaseOrderDetailDataGridView.Size = new System.Drawing.Size(767, 138);
            this.purchaseOrderDetailDataGridView.TabIndex = 28;
            this.purchaseOrderDetailDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.purchaseOrderDetailDataGridView_DataBindingComplete);
            this.purchaseOrderDetailDataGridView.SelectionChanged += new System.EventHandler(this.purchaseOrderDetailDataGridView_SelectionChanged);
            // 
            // shipMethodBindingSource
            // 
            this.shipMethodBindingSource.DataMember = "ShipMethod";
            this.shipMethodBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // shipMethodTableAdapter
            // 
            this.shipMethodTableAdapter.ClearBeforeFill = true;
            // 
            // shipperNameComboBox
            // 
            this.shipperNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "ShipMethodID", true));
            this.shipperNameComboBox.DataSource = this.shipMethodBindingSource;
            this.shipperNameComboBox.DisplayMember = "Name";
            this.shipperNameComboBox.FormattingEnabled = true;
            this.shipperNameComboBox.Location = new System.Drawing.Point(116, 177);
            this.shipperNameComboBox.Name = "shipperNameComboBox";
            this.shipperNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.shipperNameComboBox.TabIndex = 29;
            this.shipperNameComboBox.ValueMember = "ShipMethodID";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseOrderHeaderBindingSource, "EmployeeID", true));
            this.employeeComboBox.DataSource = this.employeeNameBindingSource;
            this.employeeComboBox.DisplayMember = "LastFirstName";
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(116, 119);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(144, 21);
            this.employeeComboBox.TabIndex = 30;
            this.employeeComboBox.ValueMember = "BusinessEntityID";
            // 
            // employeeNameBindingSource
            // 
            this.employeeNameBindingSource.DataMember = "EmployeeName";
            this.employeeNameBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // employeeNameTableAdapter
            // 
            this.employeeNameTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Order Header";
            // 
            // subTotalGridViewLabel
            // 
            this.subTotalGridViewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalGridViewLabel.Location = new System.Drawing.Point(199, 392);
            this.subTotalGridViewLabel.Name = "subTotalGridViewLabel";
            this.subTotalGridViewLabel.Size = new System.Drawing.Size(77, 23);
            this.subTotalGridViewLabel.TabIndex = 32;
            this.subTotalGridViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxGridViewLabel
            // 
            this.taxGridViewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxGridViewLabel.Location = new System.Drawing.Point(199, 422);
            this.taxGridViewLabel.Name = "taxGridViewLabel";
            this.taxGridViewLabel.Size = new System.Drawing.Size(77, 23);
            this.taxGridViewLabel.TabIndex = 33;
            this.taxGridViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalGridViewLabel
            // 
            this.totalGridViewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalGridViewLabel.Location = new System.Drawing.Point(199, 471);
            this.totalGridViewLabel.Name = "totalGridViewLabel";
            this.totalGridViewLabel.Size = new System.Drawing.Size(77, 23);
            this.totalGridViewLabel.TabIndex = 35;
            this.totalGridViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "DetailGridView";
            // 
            // subTotalBindingSourceLabel
            // 
            this.subTotalBindingSourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalBindingSourceLabel.Location = new System.Drawing.Point(282, 392);
            this.subTotalBindingSourceLabel.Name = "subTotalBindingSourceLabel";
            this.subTotalBindingSourceLabel.Size = new System.Drawing.Size(77, 23);
            this.subTotalBindingSourceLabel.TabIndex = 37;
            this.subTotalBindingSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxBindingSourceLabel
            // 
            this.taxBindingSourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxBindingSourceLabel.Location = new System.Drawing.Point(282, 422);
            this.taxBindingSourceLabel.Name = "taxBindingSourceLabel";
            this.taxBindingSourceLabel.Size = new System.Drawing.Size(77, 23);
            this.taxBindingSourceLabel.TabIndex = 38;
            this.taxBindingSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalBindingSourceLabel
            // 
            this.totalBindingSourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalBindingSourceLabel.Location = new System.Drawing.Point(282, 471);
            this.totalBindingSourceLabel.Name = "totalBindingSourceLabel";
            this.totalBindingSourceLabel.Size = new System.Drawing.Size(77, 23);
            this.totalBindingSourceLabel.TabIndex = 39;
            this.totalBindingSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bindingSourceLabel
            // 
            this.bindingSourceLabel.AutoSize = true;
            this.bindingSourceLabel.Location = new System.Drawing.Point(281, 376);
            this.bindingSourceLabel.Name = "bindingSourceLabel";
            this.bindingSourceLabel.Size = new System.Drawing.Size(76, 13);
            this.bindingSourceLabel.TabIndex = 40;
            this.bindingSourceLabel.Text = "BindingSource";
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Location = new System.Drawing.Point(441, 397);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(63, 13);
            this.rowCountLabel.TabIndex = 41;
            this.rowCountLabel.Text = "Row Count:";
            // 
            // rowColumnIndexLabel
            // 
            this.rowColumnIndexLabel.AutoSize = true;
            this.rowColumnIndexLabel.Location = new System.Drawing.Point(441, 427);
            this.rowColumnIndexLabel.Name = "rowColumnIndexLabel";
            this.rowColumnIndexLabel.Size = new System.Drawing.Size(81, 13);
            this.rowColumnIndexLabel.TabIndex = 42;
            this.rowColumnIndexLabel.Text = "Row/Col Index:";
            // 
            // detailIDLabel
            // 
            this.detailIDLabel.AutoSize = true;
            this.detailIDLabel.Location = new System.Drawing.Point(441, 451);
            this.detailIDLabel.Name = "detailIDLabel";
            this.detailIDLabel.Size = new System.Drawing.Size(51, 13);
            this.detailIDLabel.TabIndex = 43;
            this.detailIDLabel.Text = "Detail ID:";
            // 
            // currentCellValLabel
            // 
            this.currentCellValLabel.AutoSize = true;
            this.currentCellValLabel.Location = new System.Drawing.Point(441, 481);
            this.currentCellValLabel.Name = "currentCellValLabel";
            this.currentCellValLabel.Size = new System.Drawing.Size(82, 13);
            this.currentCellValLabel.TabIndex = 44;
            this.currentCellValLabel.Text = "Current Cell Val:";
            // 
            // rowCountBox
            // 
            this.rowCountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowCountBox.Location = new System.Drawing.Point(547, 392);
            this.rowCountBox.Name = "rowCountBox";
            this.rowCountBox.Size = new System.Drawing.Size(100, 23);
            this.rowCountBox.TabIndex = 45;
            this.rowCountBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rowIndexBox
            // 
            this.rowIndexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowIndexBox.Location = new System.Drawing.Point(547, 422);
            this.rowIndexBox.Name = "rowIndexBox";
            this.rowIndexBox.Size = new System.Drawing.Size(51, 23);
            this.rowIndexBox.TabIndex = 46;
            this.rowIndexBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailIDBox
            // 
            this.detailIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailIDBox.Location = new System.Drawing.Point(547, 448);
            this.detailIDBox.Name = "detailIDBox";
            this.detailIDBox.Size = new System.Drawing.Size(100, 23);
            this.detailIDBox.TabIndex = 47;
            this.detailIDBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentCellValBox
            // 
            this.currentCellValBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentCellValBox.Location = new System.Drawing.Point(547, 476);
            this.currentCellValBox.Name = "currentCellValBox";
            this.currentCellValBox.Size = new System.Drawing.Size(100, 23);
            this.currentCellValBox.TabIndex = 48;
            this.currentCellValBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colIndexBox
            // 
            this.colIndexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colIndexBox.Location = new System.Drawing.Point(597, 422);
            this.colIndexBox.Name = "colIndexBox";
            this.colIndexBox.Size = new System.Drawing.Size(51, 23);
            this.colIndexBox.TabIndex = 49;
            this.colIndexBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PurchaseOrderDetailID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PODetailID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderQty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LineTotal";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn7.HeaderText = "LineTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReceivedQty";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn8.HeaderText = "Rec";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RejectedQty";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn9.HeaderText = "Rej";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "StockedQty";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn10.HeaderText = "StockedQty";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // showForm1Button
            // 
            this.showForm1Button.Location = new System.Drawing.Point(284, 511);
            this.showForm1Button.Name = "showForm1Button";
            this.showForm1Button.Size = new System.Drawing.Size(75, 23);
            this.showForm1Button.TabIndex = 50;
            this.showForm1Button.Text = "Form 1";
            this.showForm1Button.UseVisualStyleBackColor = true;
            this.showForm1Button.Click += new System.EventHandler(this.showForm1Button_Click);
            // 
            // MasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 546);
            this.Controls.Add(this.showForm1Button);
            this.Controls.Add(this.colIndexBox);
            this.Controls.Add(this.currentCellValBox);
            this.Controls.Add(this.detailIDBox);
            this.Controls.Add(this.rowIndexBox);
            this.Controls.Add(this.rowCountBox);
            this.Controls.Add(this.currentCellValLabel);
            this.Controls.Add(this.detailIDLabel);
            this.Controls.Add(this.rowColumnIndexLabel);
            this.Controls.Add(this.rowCountLabel);
            this.Controls.Add(this.bindingSourceLabel);
            this.Controls.Add(this.subTotalBindingSourceLabel);
            this.Controls.Add(this.taxBindingSourceLabel);
            this.Controls.Add(this.totalBindingSourceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subTotalGridViewLabel);
            this.Controls.Add(this.taxGridViewLabel);
            this.Controls.Add(this.totalGridViewLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.shipperNameComboBox);
            this.Controls.Add(this.purchaseOrderDetailDataGridView);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.vendorComboBox);
            this.Controls.Add(purchaseOrderIDLabel);
            this.Controls.Add(this.purchaseOrderIDLabel1);
            this.Controls.Add(revisionNumberLabel);
            this.Controls.Add(this.revisionNumberTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.vendorIDTextBox);
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
            this.Name = "MasterDetailForm";
            this.Text = "MasterDetailForm";
            this.Load += new System.EventHandler(this.MasterDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderHeaderBindingNavigator)).EndInit();
            this.purchaseOrderHeaderBindingNavigator.ResumeLayout(false);
            this.purchaseOrderHeaderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNameBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox revisionNumberTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipDateDateTimePicker;
        private System.Windows.Forms.Label subTotalLabel1;
        private System.Windows.Forms.Label taxAmtLabel1;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.Label totalDueLabel1;
        private System.Windows.Forms.ComboBox vendorComboBox;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.BindingSource purchaseOrderDetailBindingSource;
        private AdventureWorksDataSetTableAdapters.PurchaseOrderDetailTableAdapter purchaseOrderDetailTableAdapter;
        private System.Windows.Forms.DataGridView purchaseOrderDetailDataGridView;
        private System.Windows.Forms.BindingSource shipMethodBindingSource;
        private AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter shipMethodTableAdapter;
        private System.Windows.Forms.ComboBox shipperNameComboBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.BindingSource employeeNameBindingSource;
        private AdventureWorksDataSetTableAdapters.EmployeeNameTableAdapter employeeNameTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subTotalGridViewLabel;
        private System.Windows.Forms.Label taxGridViewLabel;
        private System.Windows.Forms.Label totalGridViewLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label subTotalBindingSourceLabel;
        private System.Windows.Forms.Label taxBindingSourceLabel;
        private System.Windows.Forms.Label totalBindingSourceLabel;
        private System.Windows.Forms.Label bindingSourceLabel;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.Label rowColumnIndexLabel;
        private System.Windows.Forms.Label detailIDLabel;
        private System.Windows.Forms.Label currentCellValLabel;
        private System.Windows.Forms.Label rowCountBox;
        private System.Windows.Forms.Label rowIndexBox;
        private System.Windows.Forms.Label detailIDBox;
        private System.Windows.Forms.Label currentCellValBox;
        private System.Windows.Forms.Label colIndexBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button showForm1Button;
    }
}