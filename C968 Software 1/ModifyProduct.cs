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
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
            Inventory.CurrentProduct = Inventory.Products[Inventory.CurrentProductIndex];

            ModifyProductID.Text = Inventory.CurrentProduct.ProductID.ToString();
            ModifyProductName.Text = Inventory.CurrentProduct.Name;
            ModifyProductInventory.Text = Inventory.CurrentProduct.InStock.ToString();
            ModifyProductPrice.Text = Inventory.CurrentProduct.Price.ToString();
            ModifyProductMin.Text = Inventory.CurrentProduct.Min.ToString();
            ModifyProductMax.Text = Inventory.CurrentProduct.Max.ToString();

            AllPartsGrid.AutoGenerateColumns = true;
            PartsProductGrid.AutoGenerateColumns = true;

            AllPartsGrid.DataSource = Inventory.Parts;
            PartsProductGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;

            formatDataGrid(AllPartsGrid);
            formatDataGrid(PartsProductGrid);
        }
        private void formatDataGrid(DataGridView data)
        {
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            data.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            data.RowHeadersVisible = false;
            data.ReadOnly = true;
        }
        private void ModifyProductForm_Load(object sender, EventArgs e)
        {

        }

        private void EnableSaveButton()

        {

            if ((ModifyProductName.BackColor == Color.White) && (ModifyProductInventory.BackColor == Color.White) && (ModifyProductPrice.BackColor == Color.White) && (ModifyProductMin.BackColor == Color.White) && (ModifyProductMax.BackColor == Color.White)) ;
            {
                btnSave.Enabled = true;
            }


        }

        private void ModifyProductNameTextBox(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModifyProductName.Text))
            {
                ModifyProductName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ModifyProductName.BackColor = System.Drawing.Color.White;
            }
            btnSave.Enabled = true;

        }

        private void ModifyProductInventoryTextBox(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(ModifyProductInventory.Text);
                ModifyProductInventory.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyProductInventory.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(ModifyProductInventory, "Numeric only.");
                btnSave.Enabled = false;
            }

        }

        private void ModifyProductPriceTextBox(object sender, EventArgs e)
        {
            try
            {
                CheckIfDecimal(ModifyProductPrice.Text);
                ModifyProductPrice.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyProductPrice.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(ModifyProductPrice, "Decimal only.");
                btnSave.Enabled = false;
            }
        }

        private void ModifyProductMaxTextBox(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(ModifyProductMax.Text);
                ModifyProductMax.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyProductMax.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(ModifyProductMax, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void ModifyProductMinTextBox(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(ModifyProductMin.Text);
                ModifyProductMin.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyProductMin.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(ModifyProductMin, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void btnSearchClick(object sender, EventArgs e)
        {
            AllPartsGrid.ClearSelection();
            AllPartsGrid.DefaultCellStyle.SelectionBackColor = Color.MediumOrchid;
            string searchValue = ModifyProductSearch.Text;
            foreach (DataGridViewRow row in AllPartsGrid.Rows)
            {
                if ((string)row.Cells[1].Value == searchValue)
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
            PartsProductGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
            AllPartsGrid.DataSource = Inventory.Parts;
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
                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("No part deleted.", "Cancel");
                }
            }
            else if (Inventory.CurrentAssociatedIndex < 0)
            {
                MessageBox.Show("No part was found.", "Error");
            }
            PartsProductGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ModifyProductInventory.Text) < Convert.ToInt32(ModifyProductMin.Text) || Convert.ToInt32(ModifyProductInventory.Text) > Convert.ToInt32(ModifyProductMax.Text))
            {
                MessageBox.Show("Inventory must be within range of Min and Max.");
                return;
            }
            if (Convert.ToInt32(ModifyProductMax.Text) < Convert.ToInt32(ModifyProductMin.Text))
            {
                MessageBox.Show("Min value must be less than max value", "Error");
            }
            else
            {
                Inventory.CurrentProduct.ProductID = Inventory.createProductID();
                Inventory.CurrentProduct.Name = ModifyProductName.Text;
                Inventory.CurrentProduct.InStock = Int32.Parse(ModifyProductInventory.Text);
                Inventory.CurrentProduct.Price = Decimal.Parse(ModifyProductPrice.Text);
                Inventory.CurrentProduct.Max = Int32.Parse(ModifyProductMax.Text);
                Inventory.CurrentProduct.Min = Int32.Parse(ModifyProductMin.Text);

                Inventory.UpdateProduct(Convert.ToInt32(Inventory.CurrentProductIndex), Inventory.CurrentProduct);

                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();

        }

        private void PartsProductGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentAssociatedIndex = e.RowIndex;
            Inventory.CurrentAssociatedPart = Inventory.CurrentProduct.AssociatedParts[Inventory.CurrentAssociatedIndex];
        }

        private void AllPartsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPartIndex = e.RowIndex;
            Inventory.CurrentPart = Inventory.Parts[Inventory.CurrentPartIndex];
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
                throw new Exception("Inventory cannot be less than min or greater than max values.");
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
