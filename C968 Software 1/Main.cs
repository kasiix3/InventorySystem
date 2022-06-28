using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Software_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            MainScreenFormLoad();

            formatDataGrid(PartsGrid1);
            PartsGrid1.DataSource = Inventory.Parts;

            formatDataGrid(ProductsGrid);
            ProductsGrid.DataSource = Inventory.Products;

           
        }

      private void formatDataGrid (DataGridView data)
        {
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            data.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            data.RowHeadersVisible = false;
            data.ReadOnly = true;
        }
        public void MainScreenFormLoad()
        {
          
        }

        
        private void btnAddPartsClick(object sender, EventArgs e)
        {
            this.Hide();
            Add_Part addPart = new Add_Part();
            addPart.Show();
        }

        private void btnModifyPartsClick(object sender, EventArgs e)
        {

            this.Hide();
            Modify_Part modifyPart = new Modify_Part();
            modifyPart.Show();
        }

        private void btnDeletePartsClick(object sender, EventArgs e)
        {
            DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this part?",
                "Confirm", MessageBoxButtons.YesNo);
            if(deletePrompt == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in PartsGrid1.SelectedRows)
                {
                    PartsGrid1.Rows.RemoveAt(row.Index);
                }
            }
            else if(deletePrompt == DialogResult.No)
            {
                MessageBox.Show("No part deleted.", "Cancel");
            }
            
        }

        private void btnAddProductsClick(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();               

        }

        private void btnModifyProductsClick(object sender, EventArgs e)
        {
            this.Hide();
            ModifyProduct modifyProduct = new ModifyProduct();
            modifyProduct.Show();
        }

        private void btnDeleteProductsClick(object sender, EventArgs e)
        {
            DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this product?",
                "Confirm", MessageBoxButtons.YesNo);
            if (deletePrompt == DialogResult.Yes)
            {
                try
                {
                    Product product = (Product)ProductsGrid.CurrentRow.DataBoundItem;
                    if (product.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Cannot delete product associated with a part.");
                        return;
                    }
                }
                catch
                {

                }
                foreach (DataGridViewRow row in ProductsGrid.SelectedRows)
                {
                    ProductsGrid.Rows.RemoveAt(row.Index);
                }
            }
            else if (deletePrompt == DialogResult.No)
            {
                MessageBox.Show("No product deleted.", "Cancel");
            }
          
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchProductsClick(object sender, EventArgs e)
        {
            ProductsGrid.ClearSelection();
            ProductsGrid.DefaultCellStyle.SelectionBackColor = Color.MediumOrchid;
            string searchValue = MainProductsSearchTextBox.Text;
            foreach (DataGridViewRow row in ProductsGrid.Rows)
            {
                if((string)row.Cells[1].Value == searchValue)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
            bool found = false;
            if (MainProductsSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(MainProductsSearchTextBox.Text.ToUpper()))
                    {
                        ProductsGrid.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        private void btnSearchPartsClick(object sender, EventArgs e)
        {
            PartsGrid1.ClearSelection();
            PartsGrid1.DefaultCellStyle.SelectionBackColor = Color.MediumOrchid;
            bool found = false;
            if (MainPartsSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Parts.Count; i++)
                {
                    if (Inventory.Parts[i].Name.ToUpper().Contains(MainPartsSearchTextBox.Text.ToUpper()))
                    {
                        PartsGrid1.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
           
        }

        private void PartsGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPartIndex = e.RowIndex;
            Inventory.CurrentPart = Inventory.Parts[Inventory.CurrentPartIndex];
            PartsGrid1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
        }

        private void ProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentProductIndex = e.RowIndex;
            Inventory.CurrentProduct = Inventory.Products[Inventory.CurrentProductIndex];
            ProductsGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
        }


    }
}

