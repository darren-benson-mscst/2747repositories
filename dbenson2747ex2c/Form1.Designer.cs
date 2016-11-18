namespace dbenson2747ex2c
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.version1Button = new System.Windows.Forms.Button();
            this.version2Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vendorsListView1 = new System.Windows.Forms.ListView();
            this.businessEntityID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preferredVendorStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activeFlag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchasingWebServiceURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifiedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connectionString3Label = new System.Windows.Forms.Label();
            this.version3Button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vendorsSelectedLabel = new System.Windows.Forms.Label();
            this.inactiveRadioButton = new System.Windows.Forms.RadioButton();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.vendorsListView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.version4Button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.purchaseOrderListView = new System.Windows.Forms.ListView();
            this.purchaseOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.revisionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shipMethodID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shipDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taxAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.freight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchaseOrderCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.connectionStringTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ConnectionString variable, String Objects";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 82);
            this.listBox1.TabIndex = 1;
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Location = new System.Drawing.Point(6, 19);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(243, 20);
            this.connectionStringTextBox.TabIndex = 0;
            this.connectionStringTextBox.Text = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AdventureWork" +
    "s2014_Data.mdf;Integrated Security=True";
            // 
            // version1Button
            // 
            this.version1Button.Location = new System.Drawing.Point(549, 12);
            this.version1Button.Name = "version1Button";
            this.version1Button.Size = new System.Drawing.Size(75, 23);
            this.version1Button.TabIndex = 1;
            this.version1Button.Text = "Version 1";
            this.version1Button.UseVisualStyleBackColor = true;
            this.version1Button.Click += new System.EventHandler(this.version1Button_Click);
            // 
            // version2Button
            // 
            this.version2Button.Location = new System.Drawing.Point(549, 41);
            this.version2Button.Name = "version2Button";
            this.version2Button.Size = new System.Drawing.Size(75, 23);
            this.version2Button.TabIndex = 2;
            this.version2Button.Text = "Version 2";
            this.version2Button.UseVisualStyleBackColor = true;
            this.version2Button.Click += new System.EventHandler(this.version2Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.fileNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(273, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ConnectionStringBuilder, Vendor Objects";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(6, 45);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(243, 82);
            this.listBox2.TabIndex = 1;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.fileNameTextBox.TabIndex = 0;
            this.fileNameTextBox.Text = "|DataDirectory|\\AdventureWorks2014_Data.mdf";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vendorsListView1);
            this.groupBox3.Controls.Add(this.connectionString3Label);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 141);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project Properties, App Config, Connection String, Ordinal Col#, DBNull";
            // 
            // vendorsListView1
            // 
            this.vendorsListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.businessEntityID,
            this.name,
            this.creditRating,
            this.preferredVendorStatus,
            this.activeFlag,
            this.purchasingWebServiceURL,
            this.modifiedDate});
            this.vendorsListView1.GridLines = true;
            this.vendorsListView1.Location = new System.Drawing.Point(8, 46);
            this.vendorsListView1.Name = "vendorsListView1";
            this.vendorsListView1.Size = new System.Drawing.Size(655, 85);
            this.vendorsListView1.TabIndex = 1;
            this.vendorsListView1.UseCompatibleStateImageBehavior = false;
            this.vendorsListView1.View = System.Windows.Forms.View.Details;
            // 
            // businessEntityID
            // 
            this.businessEntityID.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 149;
            // 
            // creditRating
            // 
            this.creditRating.Text = "Credit";
            // 
            // preferredVendorStatus
            // 
            this.preferredVendorStatus.Text = "Pref";
            // 
            // activeFlag
            // 
            this.activeFlag.Text = "Active";
            // 
            // purchasingWebServiceURL
            // 
            this.purchasingWebServiceURL.Text = "Web";
            this.purchasingWebServiceURL.Width = 111;
            // 
            // modifiedDate
            // 
            this.modifiedDate.Text = "Modified";
            this.modifiedDate.Width = 59;
            // 
            // connectionString3Label
            // 
            this.connectionString3Label.AutoSize = true;
            this.connectionString3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionString3Label.Location = new System.Drawing.Point(6, 26);
            this.connectionString3Label.Name = "connectionString3Label";
            this.connectionString3Label.Size = new System.Drawing.Size(37, 15);
            this.connectionString3Label.TabIndex = 0;
            this.connectionString3Label.Text = "label1";
            // 
            // version3Button
            // 
            this.version3Button.Location = new System.Drawing.Point(549, 70);
            this.version3Button.Name = "version3Button";
            this.version3Button.Size = new System.Drawing.Size(75, 23);
            this.version3Button.TabIndex = 5;
            this.version3Button.Text = "Version 3";
            this.version3Button.UseVisualStyleBackColor = true;
            this.version3Button.Click += new System.EventHandler(this.version3Button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vendorsSelectedLabel);
            this.groupBox4.Controls.Add(this.inactiveRadioButton);
            this.groupBox4.Controls.Add(this.activeRadioButton);
            this.groupBox4.Controls.Add(this.vendorsListView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 141);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VendorDB Mapper Class, SqlParameter";
            // 
            // vendorsSelectedLabel
            // 
            this.vendorsSelectedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorsSelectedLabel.Location = new System.Drawing.Point(152, 16);
            this.vendorsSelectedLabel.Name = "vendorsSelectedLabel";
            this.vendorsSelectedLabel.Size = new System.Drawing.Size(137, 23);
            this.vendorsSelectedLabel.TabIndex = 4;
            this.vendorsSelectedLabel.Text = "Vendors Selected:";
            // 
            // inactiveRadioButton
            // 
            this.inactiveRadioButton.AutoSize = true;
            this.inactiveRadioButton.Location = new System.Drawing.Point(69, 19);
            this.inactiveRadioButton.Name = "inactiveRadioButton";
            this.inactiveRadioButton.Size = new System.Drawing.Size(63, 17);
            this.inactiveRadioButton.TabIndex = 3;
            this.inactiveRadioButton.Text = "Inactive";
            this.inactiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Checked = true;
            this.activeRadioButton.Location = new System.Drawing.Point(8, 19);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(55, 17);
            this.activeRadioButton.TabIndex = 2;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "Active";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            // 
            // vendorsListView2
            // 
            this.vendorsListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.vendorsListView2.GridLines = true;
            this.vendorsListView2.Location = new System.Drawing.Point(8, 46);
            this.vendorsListView2.Name = "vendorsListView2";
            this.vendorsListView2.Size = new System.Drawing.Size(655, 85);
            this.vendorsListView2.TabIndex = 1;
            this.vendorsListView2.UseCompatibleStateImageBehavior = false;
            this.vendorsListView2.View = System.Windows.Forms.View.Details;
            this.vendorsListView2.SelectedIndexChanged += new System.EventHandler(this.vendorsListView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Credit";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pref";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Active";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Web";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Modified";
            this.columnHeader7.Width = 59;
            // 
            // version4Button
            // 
            this.version4Button.Location = new System.Drawing.Point(549, 99);
            this.version4Button.Name = "version4Button";
            this.version4Button.Size = new System.Drawing.Size(75, 23);
            this.version4Button.TabIndex = 7;
            this.version4Button.Text = "Version 4";
            this.version4Button.UseVisualStyleBackColor = true;
            this.version4Button.Click += new System.EventHandler(this.version4Button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.purchaseOrderListView);
            this.groupBox5.Controls.Add(this.purchaseOrderCountLabel);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.vendorIDLabel);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(14, 454);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(760, 152);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PurchaseOrderHeader table, DB mapper, SqlParameter";
            // 
            // purchaseOrderListView
            // 
            this.purchaseOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchaseOrderID,
            this.revisionNumber,
            this.status,
            this.employeeID,
            this.shipMethodID,
            this.orderDate,
            this.shipDate,
            this.subTotal,
            this.taxAmount,
            this.freight,
            this.totalDue});
            this.purchaseOrderListView.GridLines = true;
            this.purchaseOrderListView.Location = new System.Drawing.Point(11, 52);
            this.purchaseOrderListView.Name = "purchaseOrderListView";
            this.purchaseOrderListView.Size = new System.Drawing.Size(722, 94);
            this.purchaseOrderListView.TabIndex = 4;
            this.purchaseOrderListView.UseCompatibleStateImageBehavior = false;
            this.purchaseOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // purchaseOrderID
            // 
            this.purchaseOrderID.Text = "ID";
            this.purchaseOrderID.Width = 38;
            // 
            // revisionNumber
            // 
            this.revisionNumber.Text = "Rev";
            this.revisionNumber.Width = 41;
            // 
            // status
            // 
            this.status.Text = "Stat";
            this.status.Width = 46;
            // 
            // employeeID
            // 
            this.employeeID.Text = "Emp";
            this.employeeID.Width = 52;
            // 
            // shipMethodID
            // 
            this.shipMethodID.Text = "Ship";
            // 
            // orderDate
            // 
            this.orderDate.Text = "Ordered";
            this.orderDate.Width = 86;
            // 
            // shipDate
            // 
            this.shipDate.Text = "Shipped";
            this.shipDate.Width = 82;
            // 
            // subTotal
            // 
            this.subTotal.Text = "Subtotal";
            this.subTotal.Width = 86;
            // 
            // taxAmount
            // 
            this.taxAmount.Text = "Tax";
            // 
            // freight
            // 
            this.freight.Text = "Freight";
            // 
            // totalDue
            // 
            this.totalDue.Text = "Total Due";
            this.totalDue.Width = 97;
            // 
            // purchaseOrderCountLabel
            // 
            this.purchaseOrderCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchaseOrderCountLabel.Location = new System.Drawing.Point(305, 23);
            this.purchaseOrderCountLabel.Name = "purchaseOrderCountLabel";
            this.purchaseOrderCountLabel.Size = new System.Drawing.Size(41, 23);
            this.purchaseOrderCountLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Orders Selected:";
            // 
            // vendorIDLabel
            // 
            this.vendorIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorIDLabel.Location = new System.Drawing.Point(80, 23);
            this.vendorIDLabel.Name = "vendorIDLabel";
            this.vendorIDLabel.Size = new System.Drawing.Size(67, 23);
            this.vendorIDLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 618);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.version4Button);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.version3Button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.version2Button);
            this.Controls.Add(this.version1Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Exercise 2C: Connections, Commands, DataReaders, Domain Objects";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Button version1Button;
        private System.Windows.Forms.Button version2Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label connectionString3Label;
        private System.Windows.Forms.ListView vendorsListView1;
        private System.Windows.Forms.ColumnHeader businessEntityID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader creditRating;
        private System.Windows.Forms.ColumnHeader preferredVendorStatus;
        private System.Windows.Forms.ColumnHeader activeFlag;
        private System.Windows.Forms.ColumnHeader purchasingWebServiceURL;
        private System.Windows.Forms.ColumnHeader modifiedDate;
        private System.Windows.Forms.Button version3Button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView vendorsListView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label vendorsSelectedLabel;
        private System.Windows.Forms.RadioButton inactiveRadioButton;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.Button version4Button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label vendorIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label purchaseOrderCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView purchaseOrderListView;
        private System.Windows.Forms.ColumnHeader purchaseOrderID;
        private System.Windows.Forms.ColumnHeader revisionNumber;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader employeeID;
        private System.Windows.Forms.ColumnHeader shipMethodID;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.ColumnHeader shipDate;
        private System.Windows.Forms.ColumnHeader subTotal;
        private System.Windows.Forms.ColumnHeader taxAmount;
        private System.Windows.Forms.ColumnHeader freight;
        private System.Windows.Forms.ColumnHeader totalDue;
    }
}

