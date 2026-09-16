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
    public partial class AddProductForm : Form
    {
        private Inventory inventory;
        private Product product;
        public AddProductForm(Inventory inventory)
        {
            InitializeComponent();

            this.inventory = inventory;
            product = new Product();


            int nextProductID = inventory.Products.Count + 1;
            txtProductID.Text = nextProductID.ToString();

            dgvAllParts.DataSource = inventory.AllParts;
            dgvAssociatedParts.DataSource = product.AssociatedParts;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtProductMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part first.");
                return;
            }
            Part selectedPart = (Part)dgvAllParts.CurrentRow.DataBoundItem;
            if (product.lookupAssociatedPart(selectedPart.PartID) != null)
            {
                MessageBox.Show("This part is already associated with the product.");
                return;
            }
            product.addAssociatedPart(selectedPart);

            dgvAssociatedParts.Refresh();
        }

        private void btnDeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show("Please select an associated part first.");
                return;
            }
            Part selectedPart = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;

            product.removeAssociatedPart(selectedPart.PartID);

            dgvAssociatedParts.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductInventory.Text, out int inventoryValue))
            {
                MessageBox.Show("Inventory must be a whole number.");
                return;
            }

            if (!decimal.TryParse(txtProductPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a number.");
                return;
            }

            if (!int.TryParse(txtProductMax.Text, out int max))
            {
                MessageBox.Show("Max must be a whole number.");
                return;
            }

            if (!int.TryParse(txtProductMin.Text, out int min))
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

            product.ProductID = int.Parse(txtProductID.Text);
            product.Name = txtProductName.Text;
            product.InStock = inventoryValue;
            product.Price = price;
            product.Min = min;
            product.Max = max;

            inventory.addProduct(product);

            Close();
        }


    }
}
