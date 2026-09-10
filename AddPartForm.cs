using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_System
{
    public partial class AddPartForm : Form
    {
        private Inventory inventory;
        public AddPartForm(Inventory inventory)
        {
            InitializeComponent();

            this.inventory = inventory;

            int nextPartID = inventory.AllParts.Count + 1;
            txtPartID.Text = nextPartID.ToString();

        }

        private void txtPartID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Visible = rdoInHouse.Checked;
            txtMachineID.Visible = rdoInHouse.Checked;

            lblCompanyName.Visible = !rdoInHouse.Checked;
            txtCompanyName.Visible = !rdoInHouse.Checked;
        }

        private void txtMachineID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPartInventory.Text, out int inventoryValue))
            {
                MessageBox.Show("Inventory must be a whole number.");
                return;
            }

            if (!decimal.TryParse(txtPartPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a number.");
                return;
            }

            if (!int.TryParse(txtPartMax.Text, out int max))
            {
                MessageBox.Show("Max must be a whole number.");
                return;
            }

            if (!int.TryParse(txtPartMin.Text, out int min))
            {
                MessageBox.Show("Min must be a whole number.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }
            
            if (inventoryValue < min || inventoryValue > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            int partID = int.Parse(txtPartID.Text);
            string name = txtPartName.Text;

            if (rdoInHouse.Checked)
            {
                if (!int.TryParse(txtMachineID.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a whole number.");
                    return;
                }

                Inhouse newPart = new Inhouse
                {
                    PartID = partID,
                    Name = name,
                    InStock = inventoryValue,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };

                inventory.addPart(newPart);
            }
            else
            {
                string companyName = txtCompanyName.Text;

                Outsourced newPart = new Outsourced
                {
                    PartID = partID,
                    Name = name,
                    InStock = inventoryValue,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = companyName
                };

                inventory.addPart(newPart);
            }

            Close();
        }
        


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
