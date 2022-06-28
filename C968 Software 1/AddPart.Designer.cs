
namespace C968_Software_1
{
    partial class Add_Part
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_part = new System.Windows.Forms.Label();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_inventory = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_mach_comp = new System.Windows.Forms.Label();
            this.AddPartIDTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPartNameTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPartInventoryTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPartPriceTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPartCompMachTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPartMaxTextBox1 = new System.Windows.Forms.TextBox();
            this.AddPartMinTextBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_part
            // 
            this.label_part.AutoSize = true;
            this.label_part.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_part.Location = new System.Drawing.Point(52, 36);
            this.label_part.Name = "label_part";
            this.label_part.Size = new System.Drawing.Size(46, 24);
            this.label_part.TabIndex = 0;
            this.label_part.Text = "Part";
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(154, 39);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(86, 21);
            this.InHouseRadio.TabIndex = 1;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadioChecked);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(310, 39);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(103, 21);
            this.OutsourcedRadio.TabIndex = 2;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadioChecked);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(104, 88);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 17);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "ID";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(80, 139);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name";
            // 
            // label_inventory
            // 
            this.label_inventory.AutoSize = true;
            this.label_inventory.Location = new System.Drawing.Point(59, 192);
            this.label_inventory.Name = "label_inventory";
            this.label_inventory.Size = new System.Drawing.Size(66, 17);
            this.label_inventory.TabIndex = 5;
            this.label_inventory.Text = "Inventory";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(53, 251);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(72, 17);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "Price/Cost";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(92, 311);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(33, 17);
            this.label_max.TabIndex = 7;
            this.label_max.Text = "Max";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(272, 311);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(30, 17);
            this.label_min.TabIndex = 8;
            this.label_min.Text = "Min";
            // 
            // label_mach_comp
            // 
            this.label_mach_comp.AutoSize = true;
            this.label_mach_comp.Location = new System.Drawing.Point(47, 365);
            this.label_mach_comp.Name = "label_mach_comp";
            this.label_mach_comp.Size = new System.Drawing.Size(78, 17);
            this.label_mach_comp.TabIndex = 9;
            this.label_mach_comp.Text = "Machine ID";
            // 
            // AddPartIDTextBox1
            // 
            this.AddPartIDTextBox1.Location = new System.Drawing.Point(143, 83);
            this.AddPartIDTextBox1.Name = "AddPartIDTextBox1";
            this.AddPartIDTextBox1.ReadOnly = true;
            this.AddPartIDTextBox1.Size = new System.Drawing.Size(280, 22);
            this.AddPartIDTextBox1.TabIndex = 10;
            // 
            // AddPartNameTextBox1
            // 
            this.AddPartNameTextBox1.Location = new System.Drawing.Point(143, 134);
            this.AddPartNameTextBox1.Name = "AddPartNameTextBox1";
            this.AddPartNameTextBox1.Size = new System.Drawing.Size(280, 22);
            this.AddPartNameTextBox1.TabIndex = 11;
            this.AddPartNameTextBox1.TextChanged += new System.EventHandler(this.AddPartNameTextBox1_TextChanged);
            // 
            // AddPartInventoryTextBox1
            // 
            this.AddPartInventoryTextBox1.Location = new System.Drawing.Point(143, 187);
            this.AddPartInventoryTextBox1.Name = "AddPartInventoryTextBox1";
            this.AddPartInventoryTextBox1.Size = new System.Drawing.Size(280, 22);
            this.AddPartInventoryTextBox1.TabIndex = 12;
            this.AddPartInventoryTextBox1.TextChanged += new System.EventHandler(this.AddPartInventoryTextBox1_TextChanged);
            // 
            // AddPartPriceTextBox1
            // 
            this.AddPartPriceTextBox1.Location = new System.Drawing.Point(143, 246);
            this.AddPartPriceTextBox1.Name = "AddPartPriceTextBox1";
            this.AddPartPriceTextBox1.Size = new System.Drawing.Size(280, 22);
            this.AddPartPriceTextBox1.TabIndex = 13;
            this.AddPartPriceTextBox1.TextChanged += new System.EventHandler(this.AddPartPriceTextBox1_TextChanged);
            // 
            // AddPartCompMachTextBox1
            // 
            this.AddPartCompMachTextBox1.Location = new System.Drawing.Point(143, 360);
            this.AddPartCompMachTextBox1.Name = "AddPartCompMachTextBox1";
            this.AddPartCompMachTextBox1.Size = new System.Drawing.Size(280, 22);
            this.AddPartCompMachTextBox1.TabIndex = 14;
            this.AddPartCompMachTextBox1.TextChanged += new System.EventHandler(this.AddPartCompMachTextBox_TextChanged);
            // 
            // AddPartMaxTextBox1
            // 
            this.AddPartMaxTextBox1.Location = new System.Drawing.Point(143, 311);
            this.AddPartMaxTextBox1.Name = "AddPartMaxTextBox1";
            this.AddPartMaxTextBox1.Size = new System.Drawing.Size(105, 22);
            this.AddPartMaxTextBox1.TabIndex = 15;
            this.AddPartMaxTextBox1.TextChanged += new System.EventHandler(this.AddPartMaxTextBox_TextChanged);
            // 
            // AddPartMinTextBox1
            // 
            this.AddPartMinTextBox1.Location = new System.Drawing.Point(318, 308);
            this.AddPartMinTextBox1.Name = "AddPartMinTextBox1";
            this.AddPartMinTextBox1.Size = new System.Drawing.Size(105, 22);
            this.AddPartMinTextBox1.TabIndex = 16;
            this.AddPartMinTextBox1.TextChanged += new System.EventHandler(this.AddPartMinTextBox_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 37);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 37);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // Add_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 483);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.AddPartMinTextBox1);
            this.Controls.Add(this.AddPartMaxTextBox1);
            this.Controls.Add(this.AddPartCompMachTextBox1);
            this.Controls.Add(this.AddPartPriceTextBox1);
            this.Controls.Add(this.AddPartInventoryTextBox1);
            this.Controls.Add(this.AddPartNameTextBox1);
            this.Controls.Add(this.AddPartIDTextBox1);
            this.Controls.Add(this.label_mach_comp);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_inventory);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.label_part);
            this.Name = "Add_Part";
            this.Text = "Add_Part";
            this.Load += new System.EventHandler(this.Add_Part_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_part;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_inventory;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_mach_comp;
        private System.Windows.Forms.TextBox AddPartIDTextBox1;
        private System.Windows.Forms.TextBox AddPartNameTextBox1;
        private System.Windows.Forms.TextBox AddPartInventoryTextBox1;
        private System.Windows.Forms.TextBox AddPartPriceTextBox1;
        private System.Windows.Forms.TextBox AddPartCompMachTextBox1;
        private System.Windows.Forms.TextBox AddPartMaxTextBox1;
        private System.Windows.Forms.TextBox AddPartMinTextBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}