using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class MainForm : Form
    {
        private Inventory inventory;

        private BindingList<Part> partSearchResults;
        private BindingList<Product> productSearchResults;
        public MainForm()
        {
            InitializeComponent();

            inventory = new Inventory();

            partSearchResults =
                new BindingList<Part>(inventory.AllParts);

            productSearchResults =
                new BindingList<Product>(inventory.Products);

            dgvParts.DataSource = partSearchResults;
            dgvProducts.DataSource = productSearchResults;
        }

            private void RefreshPartGrid()
        {
            partSearchResults = new BindingList<Part>(inventory.AllParts);

            dgvParts.DataSource = null;
            dgvParts.DataSource = partSearchResults;
        }

        private void RefreshProductGrid()
        {
            productSearchResults = new BindingList<Product>(inventory.Products);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productSearchResults;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm form = new AddPartForm(inventory);
            form.ShowDialog();

            RefreshPartGrid();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part first.");
                return;
            }
            Part selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;

            ModifyPartForm form = new ModifyPartForm(inventory, selectedPart);
            form.ShowDialog();

            RefreshPartGrid();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part first.");
                return;
            }

            Part selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;

            foreach (Product product in inventory.Products)
            {
                if (product.lookupAssociatedPart(selectedPart.PartID) != null)
                {
                    MessageBox.Show(
                        "This part cannot be deleted because it is associated with a product.");
                    return;
                }
            }
            DialogResult result = MessageBox.Show(
            "Are you sure you want to delete this part?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    inventory.deletePart(selectedPart);
                    RefreshPartGrid();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(inventory);
            form.ShowDialog();

            RefreshProductGrid();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            Product selectedProduct =
                (Product)dgvProducts.CurrentRow.DataBoundItem;

            ModifyProductForm form =
                new ModifyProductForm(inventory, selectedProduct);

            form.ShowDialog();

            RefreshProductGrid();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?","Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                inventory.removeProduct(selectedProduct.ProductID);
                RefreshProductGrid();
            }
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

            partSearchResults = filteredParts;

            dgvParts.DataSource = null;
            dgvParts.DataSource = partSearchResults;
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchText = txtProductSearch.Text.Trim();

            BindingList<Product> filteredProducts =
                new BindingList<Product>();

            foreach (Product product in inventory.Products)
            {
                if (searchText == "" ||
                    product.ProductID.ToString().Contains(searchText) ||
                    product.Name.ToLower().Contains(searchText.ToLower()))
                {
                    filteredProducts.Add(product);
                }
            }

            productSearchResults = filteredProducts;

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productSearchResults;
        }
    }
}
