namespace dbenson2747ex1a1
{
    partial class ShipDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipDetailsForm));
            System.Windows.Forms.Label shipMethodIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label shipBaseLabel;
            System.Windows.Forms.Label shipRateLabel;
            this.adventureWorksDataSet = new dbenson2747ex1a1.AdventureWorksDataSet();
            this.shipMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipMethodTableAdapter = new dbenson2747ex1a1.AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter();
            this.tableAdapterManager = new dbenson2747ex1a1.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.shipMethodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.shipMethodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.shipMethodIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.shipBaseTextBox = new System.Windows.Forms.TextBox();
            this.shipRateTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            shipMethodIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            shipBaseLabel = new System.Windows.Forms.Label();
            shipRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingNavigator)).BeginInit();
            this.shipMethodBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ShipMethodTableAdapter = this.shipMethodTableAdapter;
            this.tableAdapterManager.UpdateOrder = dbenson2747ex1a1.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shipMethodBindingNavigator
            // 
            this.shipMethodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shipMethodBindingNavigator.BindingSource = this.shipMethodBindingSource;
            this.shipMethodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shipMethodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shipMethodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.shipMethodBindingNavigatorSaveItem});
            this.shipMethodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shipMethodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shipMethodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shipMethodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shipMethodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shipMethodBindingNavigator.Name = "shipMethodBindingNavigator";
            this.shipMethodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shipMethodBindingNavigator.Size = new System.Drawing.Size(353, 25);
            this.shipMethodBindingNavigator.TabIndex = 0;
            this.shipMethodBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // shipMethodBindingNavigatorSaveItem
            // 
            this.shipMethodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shipMethodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shipMethodBindingNavigatorSaveItem.Image")));
            this.shipMethodBindingNavigatorSaveItem.Name = "shipMethodBindingNavigatorSaveItem";
            this.shipMethodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shipMethodBindingNavigatorSaveItem.Text = "Save Data";
            this.shipMethodBindingNavigatorSaveItem.Click += new System.EventHandler(this.shipMethodBindingNavigatorSaveItem_Click);
            // 
            // shipMethodIDLabel
            // 
            shipMethodIDLabel.AutoSize = true;
            shipMethodIDLabel.Location = new System.Drawing.Point(40, 40);
            shipMethodIDLabel.Name = "shipMethodIDLabel";
            shipMethodIDLabel.Size = new System.Drawing.Size(84, 13);
            shipMethodIDLabel.TabIndex = 1;
            shipMethodIDLabel.Text = "Ship Method ID:";
            // 
            // shipMethodIDTextBox
            // 
            this.shipMethodIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource, "ShipMethodID", true));
            this.shipMethodIDTextBox.Location = new System.Drawing.Point(130, 37);
            this.shipMethodIDTextBox.Name = "shipMethodIDTextBox";
            this.shipMethodIDTextBox.Size = new System.Drawing.Size(40, 20);
            this.shipMethodIDTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(40, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(130, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // shipBaseLabel
            // 
            shipBaseLabel.AutoSize = true;
            shipBaseLabel.Location = new System.Drawing.Point(40, 92);
            shipBaseLabel.Name = "shipBaseLabel";
            shipBaseLabel.Size = new System.Drawing.Size(58, 13);
            shipBaseLabel.TabIndex = 5;
            shipBaseLabel.Text = "Ship Base:";
            // 
            // shipBaseTextBox
            // 
            this.shipBaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource, "ShipBase", true));
            this.shipBaseTextBox.Location = new System.Drawing.Point(130, 89);
            this.shipBaseTextBox.Name = "shipBaseTextBox";
            this.shipBaseTextBox.Size = new System.Drawing.Size(59, 20);
            this.shipBaseTextBox.TabIndex = 6;
            // 
            // shipRateLabel
            // 
            shipRateLabel.AutoSize = true;
            shipRateLabel.Location = new System.Drawing.Point(40, 118);
            shipRateLabel.Name = "shipRateLabel";
            shipRateLabel.Size = new System.Drawing.Size(57, 13);
            shipRateLabel.TabIndex = 7;
            shipRateLabel.Text = "Ship Rate:";
            // 
            // shipRateTextBox
            // 
            this.shipRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipMethodBindingSource, "ShipRate", true));
            this.shipRateTextBox.Location = new System.Drawing.Point(130, 115);
            this.shipRateTextBox.Name = "shipRateTextBox";
            this.shipRateTextBox.Size = new System.Drawing.Size(47, 20);
            this.shipRateTextBox.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(130, 152);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ShipDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 201);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(shipMethodIDLabel);
            this.Controls.Add(this.shipMethodIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(shipBaseLabel);
            this.Controls.Add(this.shipBaseTextBox);
            this.Controls.Add(shipRateLabel);
            this.Controls.Add(this.shipRateTextBox);
            this.Controls.Add(this.shipMethodBindingNavigator);
            this.Name = "ShipDetailsForm";
            this.Text = "ShipDetailsForm";
            this.Load += new System.EventHandler(this.ShipDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingNavigator)).EndInit();
            this.shipMethodBindingNavigator.ResumeLayout(false);
            this.shipMethodBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource shipMethodBindingSource;
        private AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter shipMethodTableAdapter;
        private AdventureWorksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shipMethodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton shipMethodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox shipMethodIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox shipBaseTextBox;
        private System.Windows.Forms.TextBox shipRateTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}