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
    public partial class AddProduct : Form
    {
        public int CurrentPart { get; private set; }
        public AddProduct()
        {
            InitializeComponent();
            Product product = new Product();
            Inventory.CurrentProduct = product;
            formatDataGrid(AddPartGrid);
            formatDataGrid(AddProductGrid);

            
            AddPartGrid.AutoGenerateColumns = true;
            AddProductGrid.AutoGenerateColumns = true;
            AddPartGrid.DataSource = Inventory.Parts;
            AddProductGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;

        }

        private void formatDataGrid(DataGridView data)
        {
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            data.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            data.RowHeadersVisible = false;
            data.ReadOnly = true;
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(AddProductInventory.Text) < Convert.ToInt32(AddProductMin.Text) || Convert.ToInt32(AddProductInventory.Text) > Convert.ToInt32(AddProductMax.Text))
            {
                MessageBox.Show("Inventory must be within range of Min and Max.");
                return;
            }
            if(Convert.ToInt32(AddProductMax.Text) < Convert.ToInt32(AddProductMin.Text))
            {
                MessageBox.Show("Min value must be less than max value", "Error");
            }
            else
            {
                Inventory.CurrentProduct.ProductID = Inventory.createProductID();
                Inventory.CurrentProduct.Name = AddProductName.Text;
                Inventory.CurrentProduct.InStock = Int32.Parse(AddProductInventory.Text);
                Inventory.CurrentProduct.Price = Decimal.Parse(AddProductPrice.Text);
                Inventory.CurrentProduct.Max = Int32.Parse(AddProductMax.Text);
                Inventory.CurrentProduct.Min = Int32.Parse(AddProductMin.Text);

                Inventory.AddProduct(Inventory.CurrentProduct);

                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void EnableSaveButton()

        {

            if ((AddProductName.BackColor == Color.White) && (AddProductInventory.BackColor == Color.White) && (AddProductPrice.BackColor == Color.White) && (AddProductMin.BackColor == Color.White) && (AddProductMax.BackColor == Color.White)) ;
            {
                btnAdd.Enabled = true;
            }


        }

        private void AddProductNameTextBox(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddProductName.Text))
            {
                AddProductName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                AddProductName.BackColor = System.Drawing.Color.White;
            }
            btnAdd.Enabled = true;

        }

        private void AddProductInventoryTextBox(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(AddProductInventory.Text);
                AddProductInventory.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddProductInventory.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(AddProductInventory, "Numeric only.");
                btnAdd.Enabled = false;
            }
        }

        private void AddProductPriceTextBox(object sender, EventArgs e)
        {
            try
            {
                CheckIfDecimal(AddProductPrice.Text);
                AddProductPrice.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddProductPrice.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(AddProductPrice, "Decimal only.");
                btnAdd.Enabled = false;
            }
        }

        private void AddProductMaxTextBox(object sender, EventArgs e)
        {
            
            try
            {
                CheckIfNumeric(AddProductMax.Text);
                AddProductMax.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddProductMax.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(AddProductMax, "Numeric only.");
                btnAdd.Enabled = false;
            }
        }

        private void AddProductMinTextBox(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(AddProductMin.Text);
                AddProductMin.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddProductMin.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(AddProductMin, "Numeric only.");
                btnAdd.Enabled = false;
            }
        }

        private void btnSearchClick(object sender, EventArgs e)
        {
            AddPartGrid.ClearSelection();
            AddPartGrid.DefaultCellStyle.SelectionBackColor = Color.MediumOrchid;
            string searchValue = AddProductSearch.Text;
            foreach (DataGridViewRow row in AddPartGrid.Rows)
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
        }

       

        private void btnAddClick(object sender, EventArgs e)
        {
            Inventory.CurrentProduct.AddAssociatedPart(Inventory.CurrentPart);
            AddProductGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
            AddPartGrid.DataSource = Inventory.Parts;
        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this part?",
                "Confirm", MessageBoxButtons.YesNo);
            if (Inventory.CurrentAssociatedIndex >= 0)
            {
                if (deletePrompt == DialogResult.Yes)
                {
                    Inventory.CurrentProduct.RemoveAssociatedPart(Inventory.CurrentAssociatedIndex);
                }
                else if(DialogResult == DialogResult.No)
                {
                    MessageBox.Show("No part deleted.", "Cancel");
                }
            }
            else if(Inventory.CurrentAssociatedIndex < 0)
            {
                MessageBox.Show("No part was found.", "Error");
            }
            AddPartGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
        }

        private void AddPartGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPartIndex = e.RowIndex;
            Inventory.CurrentPart = Inventory.Parts[Inventory.CurrentPartIndex];
        }

        private void AddProductGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentAssociatedIndex = e.RowIndex;
            Inventory.CurrentAssociatedPart = Inventory.CurrentProduct.AssociatedParts[Inventory.CurrentAssociatedIndex];
        }
        private static void CompareValues(int min, int max)
        {
            if (min > max)
            {
                throw new Exception("Min value must be less than Max value.");
            }
        }

        private static void InBetweenValues(int inventory, int min, int max)
        {
            if (inventory < min || inventory > max)
            {
                throw new Exception("Iventory cannot less than min or greater than max values.");
            }
        }
        private void CheckIfNumeric(string checkData)
        {
            var isNumeric = int.TryParse(checkData, out int n);
            if (isNumeric == false)
            {
                throw new Exception();
            }
        }
        private void CheckIfDecimal(string checkDec)
        {
            decimal decNum;
            var isDecimal = decimal.TryParse(checkDec, out decNum);
            if (isDecimal == false)
            {
                throw new Exception();
            }
        }

    }
}
