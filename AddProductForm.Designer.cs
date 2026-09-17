namespace Inventory_System
{
    partial class AddProductForm
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductInventory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.btnAddAssociatedPart = new System.Windows.Forms.Button();
            this.btnDeleteAssociatedPart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.lblProductH1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(63, 193);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(18, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "ID";
            this.lblProductID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(140, 186);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(133, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(140, 234);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(133, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtProductInventory
            // 
            this.txtProductInventory.Location = new System.Drawing.Point(140, 284);
            this.txtProductInventory.Name = "txtProductInventory";
            this.txtProductInventory.Size = new System.Drawing.Size(133, 20);
            this.txtProductInventory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inventory";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(140, 334);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(133, 20);
            this.txtProductPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProductMax
            // 
            this.txtProductMax.Location = new System.Drawing.Point(99, 384);
            this.txtProductMax.Name = "txtProductMax";
            this.txtProductMax.Size = new System.Drawing.Size(94, 20);
            this.txtProductMax.TabIndex = 9;
            this.txtProductMax.TextChanged += new System.EventHandler(this.txtProductMax_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max";
            // 
            // txtProductMin
            // 
            this.txtProductMin.Location = new System.Drawing.Point(258, 381);
            this.txtProductMin.Name = "txtProductMin";
            this.txtProductMin.Size = new System.Drawing.Size(94, 20);
            this.txtProductMin.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Min";
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(428, 69);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.Size = new System.Drawing.Size(477, 185);
            this.dgvAllParts.TabIndex = 12;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(428, 320);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.Size = new System.Drawing.Size(477, 185);
            this.dgvAssociatedParts.TabIndex = 13;
            // 
            // btnAddAssociatedPart
            // 
            this.btnAddAssociatedPart.Location = new System.Drawing.Point(810, 267);
            this.btnAddAssociatedPart.Name = "btnAddAssociatedPart";
            this.btnAddAssociatedPart.Size = new System.Drawing.Size(69, 37);
            this.btnAddAssociatedPart.TabIndex = 14;
            this.btnAddAssociatedPart.Text = "Add";
            this.btnAddAssociatedPart.UseVisualStyleBackColor = true;
            this.btnAddAssociatedPart.Click += new System.EventHandler(this.btnAddAssociatedPart_Click);
            // 
            // btnDeleteAssociatedPart
            // 
            this.btnDeleteAssociatedPart.Location = new System.Drawing.Point(810, 520);
            this.btnDeleteAssociatedPart.Name = "btnDeleteAssociatedPart";
            this.btnDeleteAssociatedPart.Size = new System.Drawing.Size(69, 37);
            this.btnDeleteAssociatedPart.TabIndex = 15;
            this.btnDeleteAssociatedPart.Text = "Delete";
            this.btnDeleteAssociatedPart.UseVisualStyleBackColor = true;
            this.btnDeleteAssociatedPart.Click += new System.EventHandler(this.btnDeleteAssociatedPart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(810, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 37);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(711, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 37);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(730, 36);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(175, 20);
            this.txtPartSearch.TabIndex = 18;
            this.txtPartSearch.TextChanged += new System.EventHandler(this.txtPartSearch_TextChanged);
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(649, 33);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPart.TabIndex = 19;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            this.btnSearchPart.Click += new System.EventHandler(this.btnSearchPart_Click);
            // 
            // lblProductH1
            // 
            this.lblProductH1.AutoSize = true;
            this.lblProductH1.Location = new System.Drawing.Point(425, 43);
            this.lblProductH1.Name = "lblProductH1";
            this.lblProductH1.Size = new System.Drawing.Size(95, 13);
            this.lblProductH1.TabIndex = 20;
            this.lblProductH1.Text = "All candidate Parts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Parts associated with this Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 631);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProductH1);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.txtPartSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteAssociatedPart);
            this.Controls.Add(this.btnAddAssociatedPart);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvAllParts);
            this.Controls.Add(this.txtProductMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductInventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Button btnAddAssociatedPart;
        private System.Windows.Forms.Button btnDeleteAssociatedPart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPartSearch;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.Label lblProductH1;
        private System.Windows.Forms.Label label6;
    }
}