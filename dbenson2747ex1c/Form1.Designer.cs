namespace dbenson2747ex1c
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label productNumberLabel;
            System.Windows.Forms.Label reorderPointLabel;
            System.Windows.Forms.Label listPriceLabel;
            System.Windows.Forms.Label weightUnitMeasureCodeLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label productSubcategoryIDLabel;
            System.Windows.Forms.Label sellStartDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label lowestListPriceLabel;
            System.Windows.Forms.Label listPriceChangeLabel;
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productIDBoundLabel = new System.Windows.Forms.Label();
            this.nameBoundLabel = new System.Windows.Forms.Label();
            this.productNumberBoundLabel = new System.Windows.Forms.Label();
            this.reorderPointBoundLabel = new System.Windows.Forms.Label();
            this.listPriceBoundLabel = new System.Windows.Forms.Label();
            this.measureCodeBoundLabel = new System.Windows.Forms.Label();
            this.weightBoundLabel = new System.Windows.Forms.Label();
            this.productCategoryBoundLabel = new System.Windows.Forms.Label();
            this.sellStartDateBoundLabel = new System.Windows.Forms.Label();
            this.listPriceBoundLabel2 = new System.Windows.Forms.Label();
            this.productIDBoundLabel2 = new System.Windows.Forms.Label();
            this.sellStartDateBoundLabel2 = new System.Windows.Forms.Label();
            this.productNumberBoundLabel2 = new System.Windows.Forms.Label();
            this.productSubCategoryNameLabel = new System.Windows.Forms.Label();
            this.productCategoryIDLabel = new System.Windows.Forms.Label();
            this.productCategoryNameLabel = new System.Windows.Forms.Label();
            this.unitMeasureNameLabel = new System.Windows.Forms.Label();
            this.productSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet = new dbenson2747ex1c.AdventureWorksDataSet();
            this.productTableAdapter = new dbenson2747ex1c.AdventureWorksDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new dbenson2747ex1c.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.productSubcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSubcategoryTableAdapter = new dbenson2747ex1c.AdventureWorksDataSetTableAdapters.ProductSubcategoryTableAdapter();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryTableAdapter = new dbenson2747ex1c.AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter();
            this.unitMeasureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitMeasureTableAdapter = new dbenson2747ex1c.AdventureWorksDataSetTableAdapters.UnitMeasureTableAdapter();
            this.lowestListPriceLabel1 = new System.Windows.Forms.Label();
            this.listPriceChangeLabel1 = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            productNumberLabel = new System.Windows.Forms.Label();
            reorderPointLabel = new System.Windows.Forms.Label();
            listPriceLabel = new System.Windows.Forms.Label();
            weightUnitMeasureCodeLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            productSubcategoryIDLabel = new System.Windows.Forms.Label();
            sellStartDateLabel = new System.Windows.Forms.Label();
            lowestListPriceLabel = new System.Windows.Forms.Label();
            listPriceChangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            this.productSummaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitMeasureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(12, 34);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 1;
            productIDLabel.Text = "Product ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // productNumberLabel
            // 
            productNumberLabel.AutoSize = true;
            productNumberLabel.Location = new System.Drawing.Point(12, 86);
            productNumberLabel.Name = "productNumberLabel";
            productNumberLabel.Size = new System.Drawing.Size(87, 13);
            productNumberLabel.TabIndex = 5;
            productNumberLabel.Text = "Product Number:";
            // 
            // reorderPointLabel
            // 
            reorderPointLabel.AutoSize = true;
            reorderPointLabel.Location = new System.Drawing.Point(12, 112);
            reorderPointLabel.Name = "reorderPointLabel";
            reorderPointLabel.Size = new System.Drawing.Size(75, 13);
            reorderPointLabel.TabIndex = 7;
            reorderPointLabel.Text = "Reorder Point:";
            // 
            // listPriceLabel
            // 
            listPriceLabel.AutoSize = true;
            listPriceLabel.Location = new System.Drawing.Point(12, 138);
            listPriceLabel.Name = "listPriceLabel";
            listPriceLabel.Size = new System.Drawing.Size(53, 13);
            listPriceLabel.TabIndex = 9;
            listPriceLabel.Text = "List Price:";
            // 
            // weightUnitMeasureCodeLabel
            // 
            weightUnitMeasureCodeLabel.AutoSize = true;
            weightUnitMeasureCodeLabel.Location = new System.Drawing.Point(12, 164);
            weightUnitMeasureCodeLabel.Name = "weightUnitMeasureCodeLabel";
            weightUnitMeasureCodeLabel.Size = new System.Drawing.Size(138, 13);
            weightUnitMeasureCodeLabel.TabIndex = 11;
            weightUnitMeasureCodeLabel.Text = "Weight Unit Measure Code:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(12, 190);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 13;
            weightLabel.Text = "Weight:";
            // 
            // productSubcategoryIDLabel
            // 
            productSubcategoryIDLabel.AutoSize = true;
            productSubcategoryIDLabel.Location = new System.Drawing.Point(12, 216);
            productSubcategoryIDLabel.Name = "productSubcategoryIDLabel";
            productSubcategoryIDLabel.Size = new System.Drawing.Size(124, 13);
            productSubcategoryIDLabel.TabIndex = 15;
            productSubcategoryIDLabel.Text = "Product Subcategory ID:";
            // 
            // sellStartDateLabel
            // 
            sellStartDateLabel.AutoSize = true;
            sellStartDateLabel.Location = new System.Drawing.Point(12, 243);
            sellStartDateLabel.Name = "sellStartDateLabel";
            sellStartDateLabel.Size = new System.Drawing.Size(78, 13);
            sellStartDateLabel.TabIndex = 17;
            sellStartDateLabel.Text = "Sell Start Date:";
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            this.productBindingNavigator.RefreshItems += new System.EventHandler(this.productBindingNavigator_RefreshItems);
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
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // productIDBoundLabel
            // 
            this.productIDBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productIDBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDBoundLabel.Location = new System.Drawing.Point(161, 34);
            this.productIDBoundLabel.Name = "productIDBoundLabel";
            this.productIDBoundLabel.Size = new System.Drawing.Size(71, 20);
            this.productIDBoundLabel.TabIndex = 19;
            this.productIDBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productIDBoundLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameBoundLabel
            // 
            this.nameBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.nameBoundLabel.Location = new System.Drawing.Point(161, 60);
            this.nameBoundLabel.Name = "nameBoundLabel";
            this.nameBoundLabel.Size = new System.Drawing.Size(180, 20);
            this.nameBoundLabel.TabIndex = 20;
            this.nameBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNumberBoundLabel
            // 
            this.productNumberBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNumberBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductNumber", true));
            this.productNumberBoundLabel.Location = new System.Drawing.Point(161, 86);
            this.productNumberBoundLabel.Name = "productNumberBoundLabel";
            this.productNumberBoundLabel.Size = new System.Drawing.Size(135, 20);
            this.productNumberBoundLabel.TabIndex = 21;
            this.productNumberBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reorderPointBoundLabel
            // 
            this.reorderPointBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reorderPointBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ReorderPoint", true));
            this.reorderPointBoundLabel.Location = new System.Drawing.Point(161, 112);
            this.reorderPointBoundLabel.Name = "reorderPointBoundLabel";
            this.reorderPointBoundLabel.Size = new System.Drawing.Size(63, 20);
            this.reorderPointBoundLabel.TabIndex = 22;
            this.reorderPointBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listPriceBoundLabel
            // 
            this.listPriceBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPriceBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.listPriceBoundLabel.Location = new System.Drawing.Point(161, 138);
            this.listPriceBoundLabel.Name = "listPriceBoundLabel";
            this.listPriceBoundLabel.Size = new System.Drawing.Size(83, 20);
            this.listPriceBoundLabel.TabIndex = 23;
            this.listPriceBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // measureCodeBoundLabel
            // 
            this.measureCodeBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.measureCodeBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "WeightUnitMeasureCode", true));
            this.measureCodeBoundLabel.Location = new System.Drawing.Point(161, 164);
            this.measureCodeBoundLabel.Name = "measureCodeBoundLabel";
            this.measureCodeBoundLabel.Size = new System.Drawing.Size(63, 20);
            this.measureCodeBoundLabel.TabIndex = 24;
            this.measureCodeBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightBoundLabel
            // 
            this.weightBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Weight", true));
            this.weightBoundLabel.Location = new System.Drawing.Point(161, 190);
            this.weightBoundLabel.Name = "weightBoundLabel";
            this.weightBoundLabel.Size = new System.Drawing.Size(71, 20);
            this.weightBoundLabel.TabIndex = 25;
            this.weightBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productCategoryBoundLabel
            // 
            this.productCategoryBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productCategoryBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductSubcategoryID", true));
            this.productCategoryBoundLabel.Location = new System.Drawing.Point(161, 216);
            this.productCategoryBoundLabel.Name = "productCategoryBoundLabel";
            this.productCategoryBoundLabel.Size = new System.Drawing.Size(63, 20);
            this.productCategoryBoundLabel.TabIndex = 26;
            this.productCategoryBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellStartDateBoundLabel
            // 
            this.sellStartDateBoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellStartDateBoundLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SellStartDate", true));
            this.sellStartDateBoundLabel.Location = new System.Drawing.Point(161, 242);
            this.sellStartDateBoundLabel.Name = "sellStartDateBoundLabel";
            this.sellStartDateBoundLabel.Size = new System.Drawing.Size(118, 20);
            this.sellStartDateBoundLabel.TabIndex = 27;
            this.sellStartDateBoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listPriceBoundLabel2
            // 
            this.listPriceBoundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPriceBoundLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.listPriceBoundLabel2.Location = new System.Drawing.Point(258, 138);
            this.listPriceBoundLabel2.Name = "listPriceBoundLabel2";
            this.listPriceBoundLabel2.Size = new System.Drawing.Size(83, 20);
            this.listPriceBoundLabel2.TabIndex = 28;
            this.listPriceBoundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productIDBoundLabel2
            // 
            this.productIDBoundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productIDBoundLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000"));
            this.productIDBoundLabel2.Location = new System.Drawing.Point(283, 34);
            this.productIDBoundLabel2.Name = "productIDBoundLabel2";
            this.productIDBoundLabel2.Size = new System.Drawing.Size(71, 20);
            this.productIDBoundLabel2.TabIndex = 29;
            this.productIDBoundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sellStartDateBoundLabel2
            // 
            this.sellStartDateBoundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellStartDateBoundLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SellStartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.sellStartDateBoundLabel2.Location = new System.Drawing.Point(283, 242);
            this.sellStartDateBoundLabel2.Name = "sellStartDateBoundLabel2";
            this.sellStartDateBoundLabel2.Size = new System.Drawing.Size(165, 20);
            this.sellStartDateBoundLabel2.TabIndex = 30;
            this.sellStartDateBoundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNumberBoundLabel2
            // 
            this.productNumberBoundLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNumberBoundLabel2.Location = new System.Drawing.Point(313, 86);
            this.productNumberBoundLabel2.Name = "productNumberBoundLabel2";
            this.productNumberBoundLabel2.Size = new System.Drawing.Size(135, 20);
            this.productNumberBoundLabel2.TabIndex = 31;
            this.productNumberBoundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productSubCategoryNameLabel
            // 
            this.productSubCategoryNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productSubCategoryNameLabel.Location = new System.Drawing.Point(233, 216);
            this.productSubCategoryNameLabel.Name = "productSubCategoryNameLabel";
            this.productSubCategoryNameLabel.Size = new System.Drawing.Size(133, 20);
            this.productSubCategoryNameLabel.TabIndex = 32;
            this.productSubCategoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productCategoryIDLabel
            // 
            this.productCategoryIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productCategoryIDLabel.Location = new System.Drawing.Point(372, 216);
            this.productCategoryIDLabel.Name = "productCategoryIDLabel";
            this.productCategoryIDLabel.Size = new System.Drawing.Size(63, 20);
            this.productCategoryIDLabel.TabIndex = 33;
            this.productCategoryIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productCategoryNameLabel
            // 
            this.productCategoryNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productCategoryNameLabel.Location = new System.Drawing.Point(441, 216);
            this.productCategoryNameLabel.Name = "productCategoryNameLabel";
            this.productCategoryNameLabel.Size = new System.Drawing.Size(63, 20);
            this.productCategoryNameLabel.TabIndex = 34;
            this.productCategoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unitMeasureNameLabel
            // 
            this.unitMeasureNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitMeasureNameLabel.Location = new System.Drawing.Point(233, 164);
            this.unitMeasureNameLabel.Name = "unitMeasureNameLabel";
            this.unitMeasureNameLabel.Size = new System.Drawing.Size(63, 20);
            this.unitMeasureNameLabel.TabIndex = 35;
            this.unitMeasureNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productSummaryGroupBox
            // 
            this.productSummaryGroupBox.Controls.Add(listPriceChangeLabel);
            this.productSummaryGroupBox.Controls.Add(this.listPriceChangeLabel1);
            this.productSummaryGroupBox.Controls.Add(lowestListPriceLabel);
            this.productSummaryGroupBox.Controls.Add(this.lowestListPriceLabel1);
            this.productSummaryGroupBox.Location = new System.Drawing.Point(29, 283);
            this.productSummaryGroupBox.Name = "productSummaryGroupBox";
            this.productSummaryGroupBox.Size = new System.Drawing.Size(405, 98);
            this.productSummaryGroupBox.TabIndex = 36;
            this.productSummaryGroupBox.TabStop = false;
            this.productSummaryGroupBox.Text = "Product Summary";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.adventureWorksDataSet;
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductSubcategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UnitMeasureTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = dbenson2747ex1c.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productSubcategoryBindingSource
            // 
            this.productSubcategoryBindingSource.DataMember = "ProductSubcategory";
            this.productSubcategoryBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // productSubcategoryTableAdapter
            // 
            this.productSubcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // unitMeasureBindingSource
            // 
            this.unitMeasureBindingSource.DataSource = this.adventureWorksDataSet;
            this.unitMeasureBindingSource.Position = 0;
            // 
            // unitMeasureTableAdapter
            // 
            this.unitMeasureTableAdapter.ClearBeforeFill = true;
            // 
            // lowestListPriceLabel
            // 
            lowestListPriceLabel.AutoSize = true;
            lowestListPriceLabel.Location = new System.Drawing.Point(31, 25);
            lowestListPriceLabel.Name = "lowestListPriceLabel";
            lowestListPriceLabel.Size = new System.Drawing.Size(90, 13);
            lowestListPriceLabel.TabIndex = 0;
            lowestListPriceLabel.Text = "Lowest List Price:";
            // 
            // lowestListPriceLabel1
            // 
            this.lowestListPriceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestListPriceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "LowestListPrice", true));
            this.lowestListPriceLabel1.Location = new System.Drawing.Point(150, 20);
            this.lowestListPriceLabel1.Name = "lowestListPriceLabel1";
            this.lowestListPriceLabel1.Size = new System.Drawing.Size(100, 23);
            this.lowestListPriceLabel1.TabIndex = 1;
            this.lowestListPriceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listPriceChangeLabel
            // 
            listPriceChangeLabel.AutoSize = true;
            listPriceChangeLabel.Location = new System.Drawing.Point(28, 55);
            listPriceChangeLabel.Name = "listPriceChangeLabel";
            listPriceChangeLabel.Size = new System.Drawing.Size(93, 13);
            listPriceChangeLabel.TabIndex = 2;
            listPriceChangeLabel.Text = "List Price Change:";
            // 
            // listPriceChangeLabel1
            // 
            this.listPriceChangeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPriceChangeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ListPriceChange", true));
            this.listPriceChangeLabel1.Location = new System.Drawing.Point(150, 55);
            this.listPriceChangeLabel1.Name = "listPriceChangeLabel1";
            this.listPriceChangeLabel1.Size = new System.Drawing.Size(100, 23);
            this.listPriceChangeLabel1.TabIndex = 3;
            this.listPriceChangeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 381);
            this.Controls.Add(this.productSummaryGroupBox);
            this.Controls.Add(this.unitMeasureNameLabel);
            this.Controls.Add(this.productCategoryNameLabel);
            this.Controls.Add(this.productCategoryIDLabel);
            this.Controls.Add(this.productSubCategoryNameLabel);
            this.Controls.Add(this.productNumberBoundLabel2);
            this.Controls.Add(this.sellStartDateBoundLabel2);
            this.Controls.Add(this.productIDBoundLabel2);
            this.Controls.Add(this.listPriceBoundLabel2);
            this.Controls.Add(this.sellStartDateBoundLabel);
            this.Controls.Add(this.productCategoryBoundLabel);
            this.Controls.Add(this.weightBoundLabel);
            this.Controls.Add(this.measureCodeBoundLabel);
            this.Controls.Add(this.listPriceBoundLabel);
            this.Controls.Add(this.reorderPointBoundLabel);
            this.Controls.Add(this.productNumberBoundLabel);
            this.Controls.Add(this.nameBoundLabel);
            this.Controls.Add(this.productIDBoundLabel);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(productNumberLabel);
            this.Controls.Add(reorderPointLabel);
            this.Controls.Add(listPriceLabel);
            this.Controls.Add(weightUnitMeasureCodeLabel);
            this.Controls.Add(weightLabel);
            this.Controls.Add(productSubcategoryIDLabel);
            this.Controls.Add(sellStartDateLabel);
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            this.productSummaryGroupBox.ResumeLayout(false);
            this.productSummaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitMeasureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private AdventureWorksDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.Label productIDBoundLabel;
        private System.Windows.Forms.Label nameBoundLabel;
        private System.Windows.Forms.Label productNumberBoundLabel;
        private System.Windows.Forms.Label reorderPointBoundLabel;
        private System.Windows.Forms.Label listPriceBoundLabel;
        private System.Windows.Forms.Label measureCodeBoundLabel;
        private System.Windows.Forms.Label weightBoundLabel;
        private System.Windows.Forms.Label productCategoryBoundLabel;
        private System.Windows.Forms.Label sellStartDateBoundLabel;
        private System.Windows.Forms.Label listPriceBoundLabel2;
        private System.Windows.Forms.Label productIDBoundLabel2;
        private System.Windows.Forms.Label sellStartDateBoundLabel2;
        private System.Windows.Forms.Label productNumberBoundLabel2;
        private System.Windows.Forms.Label productSubCategoryNameLabel;
        private System.Windows.Forms.BindingSource productSubcategoryBindingSource;
        private AdventureWorksDataSetTableAdapters.ProductSubcategoryTableAdapter productSubcategoryTableAdapter;
        private System.Windows.Forms.Label productCategoryIDLabel;
        private System.Windows.Forms.Label productCategoryNameLabel;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private AdventureWorksDataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private System.Windows.Forms.Label unitMeasureNameLabel;
        private System.Windows.Forms.BindingSource unitMeasureBindingSource;
        private AdventureWorksDataSetTableAdapters.UnitMeasureTableAdapter unitMeasureTableAdapter;
        private System.Windows.Forms.GroupBox productSummaryGroupBox;
        private System.Windows.Forms.Label listPriceChangeLabel1;
        private System.Windows.Forms.Label lowestListPriceLabel1;
    }
}

