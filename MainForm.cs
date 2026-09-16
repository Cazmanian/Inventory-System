using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class MainForm : Form
    {
        private Inventory inventory;
        public MainForm()
        {
            InitializeComponent();

            inventory = new Inventory();

            dgvParts.DataSource = inventory.AllParts;
            dgvProducts.DataSource = inventory.Products;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm form = new AddPartForm(inventory);
            form.ShowDialog();

            dgvParts.Refresh();
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

            dgvParts.Refresh();
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
                    dgvParts.Refresh();
                }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(inventory);
            form.ShowDialog();

            dgvProducts.Refresh();
        }
    }
}
