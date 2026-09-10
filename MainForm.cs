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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
