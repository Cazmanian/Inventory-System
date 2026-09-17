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
    public partial class ModifyProductForm : Form
    {

        private Inventory inventory;
        private Product selectedProduct;
        private BindingList<Part> tempAssociatedParts;
        private BindingList<Part> searchResults;
        public ModifyProductForm(Inventory inventory, Product selectedProduct)
        {
            InitializeComponent();

            this.inventory = inventory;
            this.selectedProduct = selectedProduct;

            txtProductID.Text = selectedProduct.ProductID.ToString();
            txtProductName.Text = selectedProduct.Name;
            txtProductInventory.Text = selectedProduct.InStock.ToString();
            txtProductPrice.Text = selectedProduct.Price.ToString();
            txtProductMin.Text = selectedProduct.Min.ToString();
            txtProductMax.Text = selectedProduct.Max.ToString();

            tempAssociatedParts = new BindingList<Part>(selectedProduct.AssociatedParts.ToList());
            searchResults = new BindingList<Part>(inventory.AllParts);

            dgvAllParts.DataSource = searchResults;
            dgvAssociatedParts.DataSource = tempAssociatedParts;
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part first.");
                return;
            }

            Part selectedPart =
                (Part)dgvAllParts.CurrentRow.DataBoundItem;

            if (tempAssociatedParts.Any(
                p => p.PartID == selectedPart.PartID))
            {
                MessageBox.Show(
                    "This part is already associated with the product.");
                return;
            }

            tempAssociatedParts.Add(selectedPart);

            dgvAssociatedParts.Refresh();
        }

        private void btnSearchPart_Click(object sender, EventArgs e)
        {
            string searchText = txtPartSearch.Text.Trim();

            BindingList<Part> filteredParts =
                new BindingList<Part>();

            foreach (Part part in inventory.AllParts)
            {
                if (searchText == "" ||
                    part.PartID.ToString().Contains(searchText) ||
                    part.Name.ToLower().Contains(searchText.ToLower()))
                {
                    filteredParts.Add(part);
                }
            }

            searchResults = filteredParts;

            dgvAllParts.DataSource = null;
            dgvAllParts.DataSource = searchResults;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(
    txtProductInventory.Text,
    out int inventoryValue))
            {
                MessageBox.Show(
                    "Inventory must be a whole number.");
                return;
            }

            if (!decimal.TryParse(
                txtProductPrice.Text,
                out decimal price))
            {
                MessageBox.Show(
                    "Price must be a number.");
                return;
            }

            if (!int.TryParse(
                txtProductMax.Text,
                out int max))
            {
                MessageBox.Show(
                    "Max must be a whole number.");
                return;
            }

            if (!int.TryParse(
                txtProductMin.Text,
                out int min))
            {
                MessageBox.Show(
                    "Min must be a whole number.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show(
                    "Min cannot be greater than Max.");
                return;
            }

            if (inventoryValue < min ||
                inventoryValue > max)
            {
                MessageBox.Show(
                    "Inventory must be between Min and Max.");
                return;
            }

            selectedProduct.Name = txtProductName.Text;
            selectedProduct.InStock = inventoryValue;
            selectedProduct.Price = price;
            selectedProduct.Min = min;
            selectedProduct.Max = max;

            selectedProduct.AssociatedParts =
                new BindingList<Part>(tempAssociatedParts);

            Close();
        }

        private void btnDeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select an associated part first.");
                return;
            }

            Part selectedPart =
                (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;

            tempAssociatedParts.Remove(selectedPart);

            dgvAssociatedParts.Refresh();
        }
    }
    
}
