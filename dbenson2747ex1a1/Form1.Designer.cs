namespace dbenson2747ex1a1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.shipMethodDataGridView = new System.Windows.Forms.DataGridView();
            this.detailsFormButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksDataSet = new dbenson2747ex1a1.AdventureWorksDataSet();
            this.shipMethodTableAdapter = new dbenson2747ex1a1.AdventureWorksDataSetTableAdapters.ShipMethodTableAdapter();
            this.tableAdapterManager = new dbenson2747ex1a1.AdventureWorksDataSetTableAdapters.TableAdapterManager();
            this.personFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingNavigator)).BeginInit();
            this.shipMethodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.shipMethodBindingNavigator.Size = new System.Drawing.Size(651, 25);
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
            // shipMethodDataGridView
            // 
            this.shipMethodDataGridView.AutoGenerateColumns = false;
            this.shipMethodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipMethodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.shipMethodDataGridView.DataSource = this.shipMethodBindingSource;
            this.shipMethodDataGridView.Location = new System.Drawing.Point(0, 28);
            this.shipMethodDataGridView.Name = "shipMethodDataGridView";
            this.shipMethodDataGridView.Size = new System.Drawing.Size(406, 220);
            this.shipMethodDataGridView.TabIndex = 1;
            // 
            // detailsFormButton
            // 
            this.detailsFormButton.Location = new System.Drawing.Point(42, 266);
            this.detailsFormButton.Name = "detailsFormButton";
            this.detailsFormButton.Size = new System.Drawing.Size(75, 23);
            this.detailsFormButton.TabIndex = 2;
            this.detailsFormButton.Text = "Details Form";
            this.detailsFormButton.UseVisualStyleBackColor = true;
            this.detailsFormButton.Click += new System.EventHandler(this.detailsFormButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ShipMethodID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ShipBase";
            this.dataGridViewTextBoxColumn3.HeaderText = "ShipBase";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ShipRate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ShipRate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // shipMethodBindingSource
            // 
            this.shipMethodBindingSource.DataMember = "ShipMethod";
            this.shipMethodBindingSource.DataSource = this.adventureWorksDataSet;
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipMethodTableAdapter
            // 
            this.shipMethodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.ShipMethodTableAdapter = this.shipMethodTableAdapter;
            this.tableAdapterManager.UpdateOrder = dbenson2747ex1a1.AdventureWorksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personFormButton
            // 
            this.personFormButton.Location = new System.Drawing.Point(144, 266);
            this.personFormButton.Name = "personFormButton";
            this.personFormButton.Size = new System.Drawing.Size(97, 23);
            this.personFormButton.TabIndex = 3;
            this.personFormButton.Text = "Person Form";
            this.personFormButton.UseVisualStyleBackColor = true;
            this.personFormButton.Click += new System.EventHandler(this.personFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 314);
            this.Controls.Add(this.personFormButton);
            this.Controls.Add(this.detailsFormButton);
            this.Controls.Add(this.shipMethodDataGridView);
            this.Controls.Add(this.shipMethodBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingNavigator)).EndInit();
            this.shipMethodBindingNavigator.ResumeLayout(false);
            this.shipMethodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView shipMethodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button detailsFormButton;
        private System.Windows.Forms.Button personFormButton;
    }
}

