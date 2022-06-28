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
    public partial class Modify_Part : Form
    {
       
        public DataGridViewRow PartsGrid1;
     
        public Modify_Part()
        {
            InitializeComponent();


            Inventory.CurrentPart = Inventory.Parts[Inventory.CurrentPartIndex];

            ModifyPartIDTextBox1.Text = Inventory.CurrentPart.PartID.ToString();
            ModifyPartNameTextBox1.Text = Inventory.CurrentPart.Name;
            ModifyPartInventoryTextBox1.Text = Inventory.CurrentPart.InStock.ToString();
            ModifyPartPriceTextBox1.Text = Inventory.CurrentPart.Price.ToString();
            ModifyPartMinTextBox1.Text = Inventory.CurrentPart.Min.ToString();
            ModifyPartMaxTextBox1.Text = Inventory.CurrentPart.Max.ToString();

            if (Inventory.CurrentPart is Inhouse)
            {
                label_machine_comp.Text = "MachineID";
                this.InhouseRadio.Checked = true;
                ModifyPartCompMachTextBox1.Text = ((Inhouse)Inventory.CurrentPart).MachineID.ToString();
            }
            else
            {
                label_machine_comp.Text = "Company Name";
                this.OutsourcedRadio.Checked = true;
                ModifyPartCompMachTextBox1.Text = ((Outsourced)Inventory.CurrentPart).CompanyName;
            }


        }

        private void EnableSaveButton()

        {
            if ((ModifyPartNameTextBox1.BackColor == Color.White) && (ModifyPartInventoryTextBox1.BackColor == Color.White) && (ModifyPartPriceTextBox1.BackColor == Color.White) && (ModifyPartMinTextBox1.BackColor == Color.White) && (ModifyPartMaxTextBox1.BackColor == Color.White) && (ModifyPartCompMachTextBox1.BackColor == Color.White))
            {
                btnSave.Enabled = true;
            }
        }


        private void InhouseRadioChecked(object sender, EventArgs e)
        {
            if(Inventory.CurrentPart is Inhouse)
            {
               ModifyPartCompMachTextBox1.Text = ((Inhouse)Inventory.CurrentPart).MachineID.ToString();
            }

            label_machine_comp.Text = "Machine ID";
        }

        private void OutsourcedRadioChecked(object sender, EventArgs e)
        {
            if (Inventory.CurrentPart is Outsourced)
            {
                ModifyPartCompMachTextBox1.Text = ((Outsourced)Inventory.CurrentPart).CompanyName.ToString();
            }
            label_machine_comp.Text = "Company Name";
        }

        private void CheckIfNumeric(string checkData)
        {
            var isNumeric = int.TryParse(checkData, out int n);
            if(isNumeric == false)
            {
                throw new Exception();
            }
        }
        private void CheckIfDecimal(string checkDec)
        {
            decimal decNum;
            var isDecimal = decimal.TryParse(checkDec, out decNum);
            if(isDecimal == false)
            {
                throw new Exception();
            }
        }
        private void btnCancelClick(object sender, EventArgs e)
        {

            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
           
            Inhouse inhouse = new Inhouse();
            Outsourced outsourced = new Outsourced();
            int minNum;
            int maxNum;
            int inventoryNum;
            decimal priceNum;

            minNum = Int32.Parse(ModifyPartMinTextBox1.Text);
            maxNum = Int32.Parse(ModifyPartMaxTextBox1.Text);
            inventoryNum = Int32.Parse(ModifyPartInventoryTextBox1.Text);
            priceNum = Decimal.Parse(ModifyPartPriceTextBox1.Text);



            int id = int.Parse(ModifyPartInventoryTextBox1.Text);
            string name = ModifyPartNameTextBox1.Text;
            priceNum = decimal.Parse(ModifyPartPriceTextBox1.Text);
            minNum = int.Parse(ModifyPartMinTextBox1.Text);
            maxNum = int.Parse(ModifyPartMaxTextBox1.Text);
            inventoryNum = int.Parse(ModifyPartInventoryTextBox1.Text);

            if ((minNum > maxNum))
            {
                MessageBox.Show("Min value must be less than max value.");
                return;
            }

            if ((inventoryNum < minNum) || (inventoryNum > maxNum))
            {
                MessageBox.Show("Inventory must be within range of Min and Max.");
                return;
            }

            if (InhouseRadio.Checked)
            {
                inhouse.PartID = Int32.Parse(ModifyPartIDTextBox1.Text);
                inhouse.Name = ModifyPartNameTextBox1.Text;
                inhouse.InStock = Int32.Parse(ModifyPartInventoryTextBox1.Text);
                inhouse.Price = decimal.Parse(ModifyPartPriceTextBox1.Text);
                inhouse.Max = Int32.Parse(ModifyPartMaxTextBox1.Text);
                inhouse.Min = Int32.Parse(ModifyPartMinTextBox1.Text);
                inhouse.MachineID = Int32.Parse(ModifyPartCompMachTextBox1.Text);
                Inventory.UpdatePart(Convert.ToInt32(inhouse.PartID), inhouse);

            }
            else
            {
                outsourced.PartID = Int32.Parse(ModifyPartIDTextBox1.Text);
                outsourced.Name = ModifyPartNameTextBox1.Text;
                outsourced.InStock = Int32.Parse(ModifyPartInventoryTextBox1.Text);
                outsourced.Price = decimal.Parse(ModifyPartPriceTextBox1.Text);
                outsourced.Max = Int32.Parse(ModifyPartMaxTextBox1.Text);
                outsourced.Min = Int32.Parse(ModifyPartMinTextBox1.Text);
                outsourced.CompanyName = ModifyPartCompMachTextBox1.Text;
                Inventory.UpdatePart(Convert.ToInt32(outsourced.PartID), outsourced);
            }
            Inventory.DeletePart(Inventory.CurrentPart);

            this.Hide();
            Main main = new Main();
            main.Show();
           
        }

        private void ModifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModifyPartNameTextBox1.Text))
            {
                ModifyPartNameTextBox1.BackColor = System.Drawing.Color.Salmon;
            btnSave.Enabled = false;
            }
            else
            {
                ModifyPartNameTextBox1.BackColor = System.Drawing.Color.White;
            }
            EnableSaveButton();
        }

        private void ModifyPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(ModifyPartInventoryTextBox1.Text);
                ModifyPartInventoryTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyPartInventoryTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(ModifyPartInventoryTextBox1, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void ModifyPartPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfDecimal(ModifyPartPriceTextBox1.Text);
                ModifyPartPriceTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyPartPriceTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipDec = new ToolTip();
                toolTipDec.SetToolTip(ModifyPartPriceTextBox1, "Prices must be decimal.");
                btnSave.Enabled = false;
            }
        }

        private void ModifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(ModifyPartMaxTextBox1.Text);
                ModifyPartMaxTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyPartMaxTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(ModifyPartMaxTextBox1, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void ModifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(ModifyPartMinTextBox1.Text);
                ModifyPartMinTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                ModifyPartMinTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(ModifyPartMinTextBox1, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void ModifyPartCompMachTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InhouseRadio.Checked)
            {
                if (string.IsNullOrEmpty(ModifyPartCompMachTextBox1.Text) || !(int.TryParse(ModifyPartCompMachTextBox1.Text, out int x)))
                {
                    ModifyPartCompMachTextBox1.BackColor = Color.Salmon;
                    btnSave.Enabled = false;
                }
                else
                {
                    ModifyPartCompMachTextBox1.BackColor = Color.White;
                    EnableSaveButton();
                }
            }
            if(OutsourcedRadio.Checked)
            {
                if(string.IsNullOrEmpty(ModifyPartCompMachTextBox1.Text))
                {
                    ModifyPartCompMachTextBox1.BackColor = Color.Salmon;
                    btnSave.Enabled = false;
                }
                else
                {
                    ModifyPartCompMachTextBox1.BackColor = Color.White;
                    EnableSaveButton();
                }
            }
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
    }

}
