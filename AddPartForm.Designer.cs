namespace Inventory_System
{
    partial class AddPartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartMax = new System.Windows.Forms.TextBox();
            this.txtPartMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoInHouse = new System.Windows.Forms.RadioButton();
            this.rdoOutsourced = new System.Windows.Forms.RadioButton();
            this.lblMachineID = new System.Windows.Forms.Label();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPartInventory = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(233, 66);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(127, 20);
            this.txtPartID.TabIndex = 1;
            this.txtPartID.TextChanged += new System.EventHandler(this.txtPartID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(233, 114);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(127, 20);
            this.txtPartName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price / Cost";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Location = new System.Drawing.Point(233, 198);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(127, 20);
            this.txtPartPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max";
            // 
            // txtPartMax
            // 
            this.txtPartMax.Location = new System.Drawing.Point(233, 247);
            this.txtPartMax.Name = "txtPartMax";
            this.txtPartMax.Size = new System.Drawing.Size(57, 20);
            this.txtPartMax.TabIndex = 7;
            // 
            // txtPartMin
            // 
            this.txtPartMin.Location = new System.Drawing.Point(354, 247);
            this.txtPartMin.Name = "txtPartMin";
            this.txtPartMin.Size = new System.Drawing.Size(57, 20);
            this.txtPartMin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min";
            // 
            // rdoInHouse
            // 
            this.rdoInHouse.AutoSize = true;
            this.rdoInHouse.Checked = true;
            this.rdoInHouse.Location = new System.Drawing.Point(173, 25);
            this.rdoInHouse.Name = "rdoInHouse";
            this.rdoInHouse.Size = new System.Drawing.Size(68, 17);
            this.rdoInHouse.TabIndex = 10;
            this.rdoInHouse.TabStop = true;
            this.rdoInHouse.Text = "In-House";
            this.rdoInHouse.UseVisualStyleBackColor = true;
            this.rdoInHouse.CheckedChanged += new System.EventHandler(this.rdoInHouse_CheckedChanged);
            // 
            // rdoOutsourced
            // 
            this.rdoOutsourced.AutoSize = true;
            this.rdoOutsourced.Location = new System.Drawing.Point(275, 25);
            this.rdoOutsourced.Name = "rdoOutsourced";
            this.rdoOutsourced.Size = new System.Drawing.Size(80, 17);
            this.rdoOutsourced.TabIndex = 11;
            this.rdoOutsourced.Text = "Outsourced";
            this.rdoOutsourced.UseVisualStyleBackColor = true;
            this.rdoOutsourced.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblMachineID
            // 
            this.lblMachineID.AutoSize = true;
            this.lblMachineID.Location = new System.Drawing.Point(143, 300);
            this.lblMachineID.Name = "lblMachineID";
            this.lblMachineID.Size = new System.Drawing.Size(62, 13);
            this.lblMachineID.TabIndex = 12;
            this.lblMachineID.Text = "Machine ID";
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(233, 293);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(127, 20);
            this.txtMachineID.TabIndex = 13;
            this.txtMachineID.TextChanged += new System.EventHandler(this.txtMachineID_TextChanged);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(123, 300);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 14;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.Visible = false;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(233, 293);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(127, 20);
            this.txtCompanyName.TabIndex = 15;
            this.txtCompanyName.Visible = false;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPartInventory
            // 
            this.txtPartInventory.Location = new System.Drawing.Point(233, 158);
            this.txtPartInventory.Name = "txtPartInventory";
            this.txtPartInventory.Size = new System.Drawing.Size(127, 20);
            this.txtPartInventory.TabIndex = 19;
            this.txtPartInventory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(154, 165);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 18;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.txtPartInventory);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.lblMachineID);
            this.Controls.Add(this.rdoOutsourced);
            this.Controls.Add(this.rdoInHouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPartMin);
            this.Controls.Add(this.txtPartMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartMax;
        private System.Windows.Forms.TextBox txtPartMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoInHouse;
        private System.Windows.Forms.RadioButton rdoOutsourced;
        private System.Windows.Forms.Label lblMachineID;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPartInventory;
        private System.Windows.Forms.Label lblInventory;
    }
}