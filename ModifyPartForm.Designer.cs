namespace Inventory_System
{
    partial class ModifyPartForm
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
            this.txtPartInventory = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.lblMachineID = new System.Windows.Forms.Label();
            this.rdoOutsourced = new System.Windows.Forms.RadioButton();
            this.rdoInHouse = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPartMin = new System.Windows.Forms.TextBox();
            this.txtPartMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPartInventory
            // 
            this.txtPartInventory.Location = new System.Drawing.Point(170, 167);
            this.txtPartInventory.Name = "txtPartInventory";
            this.txtPartInventory.Size = new System.Drawing.Size(127, 20);
            this.txtPartInventory.TabIndex = 39;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(91, 174);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 38;
            this.lblInventory.Text = "Inventory";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 36);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(170, 302);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(127, 20);
            this.txtCompanyName.TabIndex = 35;
            this.txtCompanyName.Visible = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(60, 309);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 34;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.Visible = false;
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(170, 302);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(127, 20);
            this.txtMachineID.TabIndex = 33;
            // 
            // lblMachineID
            // 
            this.lblMachineID.AutoSize = true;
            this.lblMachineID.Location = new System.Drawing.Point(80, 309);
            this.lblMachineID.Name = "lblMachineID";
            this.lblMachineID.Size = new System.Drawing.Size(62, 13);
            this.lblMachineID.TabIndex = 32;
            this.lblMachineID.Text = "Machine ID";
            // 
            // rdoOutsourced
            // 
            this.rdoOutsourced.AutoSize = true;
            this.rdoOutsourced.Location = new System.Drawing.Point(212, 34);
            this.rdoOutsourced.Name = "rdoOutsourced";
            this.rdoOutsourced.Size = new System.Drawing.Size(80, 17);
            this.rdoOutsourced.TabIndex = 31;
            this.rdoOutsourced.Text = "Outsourced";
            this.rdoOutsourced.UseVisualStyleBackColor = true;
            // 
            // rdoInHouse
            // 
            this.rdoInHouse.AutoSize = true;
            this.rdoInHouse.Checked = true;
            this.rdoInHouse.Location = new System.Drawing.Point(110, 34);
            this.rdoInHouse.Name = "rdoInHouse";
            this.rdoInHouse.Size = new System.Drawing.Size(68, 17);
            this.rdoInHouse.TabIndex = 30;
            this.rdoInHouse.TabStop = true;
            this.rdoInHouse.Text = "In-House";
            this.rdoInHouse.UseVisualStyleBackColor = true;
            this.rdoInHouse.CheckedChanged += new System.EventHandler(this.rdoInHouse_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Min";
            // 
            // txtPartMin
            // 
            this.txtPartMin.Location = new System.Drawing.Point(291, 256);
            this.txtPartMin.Name = "txtPartMin";
            this.txtPartMin.Size = new System.Drawing.Size(57, 20);
            this.txtPartMin.TabIndex = 28;
            // 
            // txtPartMax
            // 
            this.txtPartMax.Location = new System.Drawing.Point(170, 256);
            this.txtPartMax.Name = "txtPartMax";
            this.txtPartMax.Size = new System.Drawing.Size(57, 20);
            this.txtPartMax.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Max";
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Location = new System.Drawing.Point(170, 207);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(127, 20);
            this.txtPartPrice.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price / Cost";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(170, 123);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(127, 20);
            this.txtPartName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name";
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(170, 75);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(127, 20);
            this.txtPartID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 417);
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
            this.Name = "ModifyPartForm";
            this.Text = "ModifyPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.Label lblMachineID;
        private System.Windows.Forms.RadioButton rdoOutsourced;
        private System.Windows.Forms.RadioButton rdoInHouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartMin;
        private System.Windows.Forms.TextBox txtPartMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label1;
    }
}