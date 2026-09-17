namespace Inventory_System
{
    partial class ModifyProductForm
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
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteAssociatedPart = new System.Windows.Forms.Button();
            this.btnAddAssociatedPart = new System.Windows.Forms.Button();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.txtProductMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductInventory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(618, 26);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPart.TabIndex = 39;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            this.btnSearchPart.Click += new System.EventHandler(this.btnSearchPart_Click);
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(699, 29);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(175, 20);
            this.txtPartSearch.TabIndex = 38;
            this.txtPartSearch.TextChanged += new System.EventHandler(this.txtPartSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(680, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 37);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(779, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 37);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteAssociatedPart
            // 
            this.btnDeleteAssociatedPart.Location = new System.Drawing.Point(779, 513);
            this.btnDeleteAssociatedPart.Name = "btnDeleteAssociatedPart";
            this.btnDeleteAssociatedPart.Size = new System.Drawing.Size(69, 37);
            this.btnDeleteAssociatedPart.TabIndex = 35;
            this.btnDeleteAssociatedPart.Text = "Delete";
            this.btnDeleteAssociatedPart.UseVisualStyleBackColor = true;
            this.btnDeleteAssociatedPart.Click += new System.EventHandler(this.btnDeleteAssociatedPart_Click);
            // 
            // btnAddAssociatedPart
            // 
            this.btnAddAssociatedPart.Location = new System.Drawing.Point(779, 260);
            this.btnAddAssociatedPart.Name = "btnAddAssociatedPart";
            this.btnAddAssociatedPart.Size = new System.Drawing.Size(69, 37);
            this.btnAddAssociatedPart.TabIndex = 34;
            this.btnAddAssociatedPart.Text = "Add";
            this.btnAddAssociatedPart.UseVisualStyleBackColor = true;
            this.btnAddAssociatedPart.Click += new System.EventHandler(this.btnAddAssociatedPart_Click);
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(397, 313);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.Size = new System.Drawing.Size(477, 185);
            this.dgvAssociatedParts.TabIndex = 33;
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(397, 62);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.Size = new System.Drawing.Size(477, 185);
            this.dgvAllParts.TabIndex = 32;
            // 
            // txtProductMin
            // 
            this.txtProductMin.Location = new System.Drawing.Point(227, 374);
            this.txtProductMin.Name = "txtProductMin";
            this.txtProductMin.Size = new System.Drawing.Size(94, 20);
            this.txtProductMin.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Min";
            // 
            // txtProductMax
            // 
            this.txtProductMax.Location = new System.Drawing.Point(68, 377);
            this.txtProductMax.Name = "txtProductMax";
            this.txtProductMax.Size = new System.Drawing.Size(94, 20);
            this.txtProductMax.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Max";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(109, 327);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(133, 20);
            this.txtProductPrice.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Price";
            // 
            // txtProductInventory
            // 
            this.txtProductInventory.Location = new System.Drawing.Point(109, 277);
            this.txtProductInventory.Name = "txtProductInventory";
            this.txtProductInventory.Size = new System.Drawing.Size(133, 20);
            this.txtProductInventory.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Inventory";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(109, 227);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(133, 20);
            this.txtProductName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(109, 179);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(133, 20);
            this.txtProductID.TabIndex = 21;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(32, 186);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(18, 13);
            this.lblProductID.TabIndex = 20;
            this.lblProductID.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Parts associated with this Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "All candidate Parts";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 630);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.TextBox txtPartSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteAssociatedPart;
        private System.Windows.Forms.Button btnAddAssociatedPart;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.TextBox txtProductMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}