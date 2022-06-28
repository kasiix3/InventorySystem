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
    public partial class Add_Part : Form

    {
       

        public Add_Part()
        {
            InitializeComponent();
            Inhouse inPart = new Inhouse();
            Outsourced outPart = new Outsourced();
        }

        public DataGridViewRow PartsGrid1;
      
        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void btnSaveClick(object sender, EventArgs e)
        {

            if (Convert.ToInt32(AddPartInventoryTextBox1.Text) < Convert.ToInt32(AddPartMinTextBox1.Text) || Convert.ToInt32(AddPartInventoryTextBox1.Text) > Convert.ToInt32(AddPartMaxTextBox1.Text))
            {
                MessageBox.Show("Inventory must be within range of Min and Max.");
                return;
            }
            if(Convert.ToInt32(AddPartMaxTextBox1.Text) > Convert.ToInt32(AddPartMinTextBox1.Text))
            {
                if (InHouseRadio.Checked)
                {
                    Inhouse inPart = new Inhouse();
                    inPart.PartID = Inventory.createPartID();
                    inPart.Name = AddPartNameTextBox1.Text;
                    inPart.InStock = Int32.Parse(AddPartInventoryTextBox1.Text);
                    inPart.Price = Decimal.Parse(AddPartPriceTextBox1.Text);
                    inPart.Max = Int32.Parse(AddPartMaxTextBox1.Text);
                    inPart.Min = Int32.Parse(AddPartMinTextBox1.Text);
                    inPart.MachineID = Int32.Parse(AddPartCompMachTextBox1.Text);
                    Inventory.AddPart(inPart);
                    
                }
                else
                {
                    Outsourced outPart = new Outsourced();
                    outPart.PartID = Inventory.createPartID();
                    outPart.Name = AddPartNameTextBox1.Text;
                    outPart.InStock = Int32.Parse(AddPartInventoryTextBox1.Text);
                    outPart.Price = Decimal.Parse(AddPartPriceTextBox1.Text);
                    outPart.Max = Int32.Parse(AddPartMaxTextBox1.Text);
                    outPart.Min = Int32.Parse(AddPartMinTextBox1.Text);
                    outPart.CompanyName = AddPartCompMachTextBox1.Text;
                    Inventory.AddPart(outPart);
                }
            }
            else
            {
                MessageBox.Show("Min value must be less than max value.");
                return;
            }
           
            
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void EnableSaveButton()

        {

            if ((AddPartNameTextBox1.BackColor == Color.White) && (AddPartInventoryTextBox1.BackColor == Color.White) && (AddPartPriceTextBox1.BackColor == Color.White) && (AddPartMinTextBox1.BackColor == Color.White) && (AddPartMaxTextBox1.BackColor == Color.White) && (AddPartCompMachTextBox1.BackColor == Color.White))
            {
                btnSave.Enabled = true;
            }


        }

        private void InHouseRadioChecked(object sender, EventArgs e)
        {
            label_mach_comp.Text = "Machine ID";
            

        }

        private void OutsourcedRadioChecked(object sender, EventArgs e)
        {
            label_mach_comp.Text = "Company Name";
            

        }

        private void AddPartIDTextBox_TextChanged(object sender, EventArgs e)
        {
            //not needed, ID does not change
        }

        private void AddPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(AddPartMaxTextBox1.Text);
                AddPartMaxTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddPartMaxTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(AddPartMaxTextBox1, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void AddPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfDecimal(AddPartMinTextBox1.Text);
                AddPartMinTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddPartMinTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(AddPartMinTextBox1, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void AddPartCompMachTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Part_Load(object sender, EventArgs e)
        {

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

        private void AddPartNameTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddPartNameTextBox1.Text))
            {
                AddPartNameTextBox1.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                AddPartNameTextBox1.BackColor = System.Drawing.Color.White;
            }
            EnableSaveButton();

        }

        private void AddPartInventoryTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfNumeric(AddPartInventoryTextBox1.Text);
                AddPartInventoryTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddPartInventoryTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipNum = new ToolTip();
                toolTipNum.SetToolTip(AddPartInventoryTextBox1, "Numeric only.");
                btnSave.Enabled = false;
            }
        }

        private void AddPartPriceTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckIfDecimal(AddPartPriceTextBox1.Text);
                AddPartPriceTextBox1.BackColor = Color.White;
                EnableSaveButton();
            }
            catch (Exception)
            {
                AddPartPriceTextBox1.BackColor = Color.Salmon;
                ToolTip toolTipDec = new ToolTip();
                toolTipDec.SetToolTip(AddPartPriceTextBox1, "Decimal only.");
                btnSave.Enabled = false;
            }

        }
    }
}
