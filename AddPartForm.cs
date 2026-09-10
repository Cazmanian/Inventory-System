using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
