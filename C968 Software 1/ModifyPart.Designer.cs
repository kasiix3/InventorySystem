
namespace C968_Software_1
{
    partial class Modify_Part
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ModifyPartMinTextBox1 = new System.Windows.Forms.TextBox();
            this.ModifyPartMaxTextBox1 = new System.Windows.Forms.TextBox();
            this.ModifyPartCompMachTextBox1 = new System.Windows.Forms.TextBox();
            this.ModifyPartPriceTextBox1 = new System.Windows.Forms.TextBox();
            this.ModifyPartInventoryTextBox1 = new System.Windows.Forms.TextBox();
            this.ModifyPartNameTextBox1 = new System.Windows.Forms.TextBox();
            this.ModifyPartIDTextBox1 = new System.Windows.Forms.TextBox();
            this.label_machine_comp = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_inventory = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.InhouseRadio = new System.Windows.Forms.RadioButton();
            this.label_modify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 37);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 37);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // ModifyPartMinTextBox1
            // 
            this.ModifyPartMinTextBox1.Location = new System.Drawing.Point(318, 308);
            this.ModifyPartMinTextBox1.Name = "ModifyPartMinTextBox1";
            this.ModifyPartMinTextBox1.Size = new System.Drawing.Size(105, 22);
            this.ModifyPartMinTextBox1.TabIndex = 35;
            this.ModifyPartMinTextBox1.TextChanged += new System.EventHandler(this.ModifyPartMinTextBox_TextChanged);
            // 
            // ModifyPartMaxTextBox1
            // 
            this.ModifyPartMaxTextBox1.Location = new System.Drawing.Point(143, 311);
            this.ModifyPartMaxTextBox1.Name = "ModifyPartMaxTextBox1";
            this.ModifyPartMaxTextBox1.Size = new System.Drawing.Size(105, 22);
            this.ModifyPartMaxTextBox1.TabIndex = 34;
            this.ModifyPartMaxTextBox1.TextChanged += new System.EventHandler(this.ModifyPartMaxTextBox_TextChanged);
            // 
            // ModifyPartCompMachTextBox1
            // 
            this.ModifyPartCompMachTextBox1.Location = new System.Drawing.Point(143, 360);
            this.ModifyPartCompMachTextBox1.Name = "ModifyPartCompMachTextBox1";
            this.ModifyPartCompMachTextBox1.Size = new System.Drawing.Size(280, 22);
            this.ModifyPartCompMachTextBox1.TabIndex = 33;
            this.ModifyPartCompMachTextBox1.TextChanged += new System.EventHandler(this.ModifyPartCompMachTextBox_TextChanged);
            // 
            // ModifyPartPriceTextBox1
            // 
            this.ModifyPartPriceTextBox1.Location = new System.Drawing.Point(143, 246);
            this.ModifyPartPriceTextBox1.Name = "ModifyPartPriceTextBox1";
            this.ModifyPartPriceTextBox1.Size = new System.Drawing.Size(280, 22);
            this.ModifyPartPriceTextBox1.TabIndex = 32;
            this.ModifyPartPriceTextBox1.TextChanged += new System.EventHandler(this.ModifyPartPriceTextBox_TextChanged);
            // 
            // ModifyPartInventoryTextBox1
            // 
            this.ModifyPartInventoryTextBox1.Location = new System.Drawing.Point(143, 187);
            this.ModifyPartInventoryTextBox1.Name = "ModifyPartInventoryTextBox1";
            this.ModifyPartInventoryTextBox1.Size = new System.Drawing.Size(280, 22);
            this.ModifyPartInventoryTextBox1.TabIndex = 31;
            this.ModifyPartInventoryTextBox1.TextChanged += new System.EventHandler(this.ModifyPartInventoryTextBox_TextChanged);
            // 
            // ModifyPartNameTextBox1
            // 
            this.ModifyPartNameTextBox1.Location = new System.Drawing.Point(143, 134);
            this.ModifyPartNameTextBox1.Name = "ModifyPartNameTextBox1";
            this.ModifyPartNameTextBox1.Size = new System.Drawing.Size(280, 22);
            this.ModifyPartNameTextBox1.TabIndex = 30;
            this.ModifyPartNameTextBox1.TextChanged += new System.EventHandler(this.ModifyPartNameTextBox_TextChanged);
            // 
            // ModifyPartIDTextBox1
            // 
            this.ModifyPartIDTextBox1.Location = new System.Drawing.Point(143, 83);
            this.ModifyPartIDTextBox1.Name = "ModifyPartIDTextBox1";
            this.ModifyPartIDTextBox1.Size = new System.Drawing.Size(280, 22);
            this.ModifyPartIDTextBox1.TabIndex = 29;
            // 
            // label_machine_comp
            // 
            this.label_machine_comp.AutoSize = true;
            this.label_machine_comp.Location = new System.Drawing.Point(47, 365);
            this.label_machine_comp.Name = "label_machine_comp";
            this.label_machine_comp.Size = new System.Drawing.Size(78, 17);
            this.label_machine_comp.TabIndex = 28;
            this.label_machine_comp.Text = "Machine ID";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(272, 311);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(30, 17);
            this.label_min.TabIndex = 27;
            this.label_min.Text = "Min";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(92, 311);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(33, 17);
            this.label_max.TabIndex = 26;
            this.label_max.Text = "Max";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(53, 251);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(72, 17);
            this.label_price.TabIndex = 25;
            this.label_price.Text = "Price/Cost";
            // 
            // label_inventory
            // 
            this.label_inventory.AutoSize = true;
            this.label_inventory.Location = new System.Drawing.Point(59, 192);
            this.label_inventory.Name = "label_inventory";
            this.label_inventory.Size = new System.Drawing.Size(66, 17);
            this.label_inventory.TabIndex = 24;
            this.label_inventory.Text = "Inventory";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(80, 139);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 23;
            this.label_name.Text = "Name";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(104, 88);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 17);
            this.label_ID.TabIndex = 22;
            this.label_ID.Text = "ID";
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(310, 39);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(103, 21);
            this.OutsourcedRadio.TabIndex = 21;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadioChecked);
            // 
            // InhouseRadio
            // 
            this.InhouseRadio.AutoSize = true;
            this.InhouseRadio.Location = new System.Drawing.Point(154, 39);
            this.InhouseRadio.Name = "InhouseRadio";
            this.InhouseRadio.Size = new System.Drawing.Size(86, 21);
            this.InhouseRadio.TabIndex = 20;
            this.InhouseRadio.TabStop = true;
            this.InhouseRadio.Text = "In-House";
            this.InhouseRadio.UseVisualStyleBackColor = true;
            this.InhouseRadio.CheckedChanged += new System.EventHandler(this.InhouseRadioChecked);
            // 
            // label_modify
            // 
            this.label_modify.AutoSize = true;
            this.label_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modify.Location = new System.Drawing.Point(46, 36);
            this.label_modify.Name = "label_modify";
            this.label_modify.Size = new System.Drawing.Size(71, 24);
            this.label_modify.TabIndex = 19;
            this.label_modify.Text = "Modify";
            // 
            // Modify_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 483);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ModifyPartMinTextBox1);
            this.Controls.Add(this.ModifyPartMaxTextBox1);
            this.Controls.Add(this.ModifyPartCompMachTextBox1);
            this.Controls.Add(this.ModifyPartPriceTextBox1);
            this.Controls.Add(this.ModifyPartInventoryTextBox1);
            this.Controls.Add(this.ModifyPartNameTextBox1);
            this.Controls.Add(this.ModifyPartIDTextBox1);
            this.Controls.Add(this.label_machine_comp);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_inventory);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InhouseRadio);
            this.Controls.Add(this.label_modify);
            this.Name = "Modify_Part";
            this.Text = "Modify_Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox ModifyPartMinTextBox1;
        private System.Windows.Forms.TextBox ModifyPartMaxTextBox1;
        private System.Windows.Forms.TextBox ModifyPartCompMachTextBox1;
        private System.Windows.Forms.TextBox ModifyPartPriceTextBox1;
        private System.Windows.Forms.TextBox ModifyPartInventoryTextBox1;
        private System.Windows.Forms.TextBox ModifyPartNameTextBox1;
        private System.Windows.Forms.TextBox ModifyPartIDTextBox1;
        private System.Windows.Forms.Label label_machine_comp;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_inventory;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.RadioButton InhouseRadio;
        private System.Windows.Forms.Label label_modify;
    }
}