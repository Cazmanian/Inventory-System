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
    public partial class ModifyPartForm : Form
    {
        private Inventory inventory;
        private Part selectedPart;
        public ModifyPartForm(Inventory inventory, Part selectedPart)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.selectedPart = selectedPart;

            txtPartID.Text = selectedPart.PartID.ToString();
            txtPartName.Text = selectedPart.Name;
            txtPartInventory.Text = selectedPart.InStock.ToString();
            txtPartPrice.Text = selectedPart.Price.ToString();
            txtPartMin.Text = selectedPart.Min.ToString();
            txtPartMax.Text = selectedPart.Max.ToString();

            if (selectedPart is Inhouse inhousePart)
            {
                rdoInHouse.Checked = true;
                txtMachineID.Text = inhousePart.MachineID.ToString();

                lblMachineID.Visible = true;
                txtMachineID.Visible = true;

                lblCompanyName.Visible = false;
                txtCompanyName.Visible = false;
            }
            else if (selectedPart is Outsourced outsourcedPart)
            {
                rdoOutsourced.Checked = true;
                txtCompanyName.Text = outsourcedPart.CompanyName;

                lblMachineID.Visible = false;
                txtMachineID.Visible = false;

                lblCompanyName.Visible = true;
                txtCompanyName.Visible = true;
            }
        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Visible = rdoInHouse.Checked;
            txtMachineID.Visible = rdoInHouse.Checked;

            lblCompanyName.Visible = !rdoInHouse.Checked;
            txtCompanyName.Visible = !rdoInHouse.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

            string name = txtPartName.Text;
            int partID = selectedPart.PartID;

            Part updatedPart;

            if (rdoInHouse.Checked)
            {
                if (!int.TryParse(txtMachineID.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a whole number.");
                    return;
                }

                updatedPart = new Inhouse
                {
                    PartID = partID,
                    Name = name,
                    InStock = inventoryValue,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };
            }
            else
            {
                updatedPart = new Outsourced
                {
                    PartID = partID,
                    Name = name,
                    InStock = inventoryValue,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = txtCompanyName.Text
                };
            }

            inventory.updatePart(partID, updatedPart);

            Close();
        }
    }
}
