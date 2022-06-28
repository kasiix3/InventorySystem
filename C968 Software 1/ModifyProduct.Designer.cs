
namespace C968_Software_1
{
    partial class ModifyProduct
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
            this.ModifyProductMin = new System.Windows.Forms.TextBox();
            this.ModifyProductMax = new System.Windows.Forms.TextBox();
            this.ModifyProductPrice = new System.Windows.Forms.TextBox();
            this.ModifyProductInventory = new System.Windows.Forms.TextBox();
            this.ModifyProductName = new System.Windows.Forms.TextBox();
            this.ModifyProductID = new System.Windows.Forms.TextBox();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_inventory = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_modprod = new System.Windows.Forms.Label();
            this.AllPartsGrid = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.ModifyProductSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label_candparts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.PartsProductGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(863, 562);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 37);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(768, 562);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 37);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // ModifyProductMin
            // 
            this.ModifyProductMin.Location = new System.Drawing.Point(307, 397);
            this.ModifyProductMin.Name = "ModifyProductMin";
            this.ModifyProductMin.Size = new System.Drawing.Size(105, 22);
            this.ModifyProductMin.TabIndex = 54;
            this.ModifyProductMin.TextChanged += new System.EventHandler(this.ModifyProductMinTextBox);
            // 
            // ModifyProductMax
            // 
            this.ModifyProductMax.Location = new System.Drawing.Point(132, 400);
            this.ModifyProductMax.Name = "ModifyProductMax";
            this.ModifyProductMax.Size = new System.Drawing.Size(105, 22);
            this.ModifyProductMax.TabIndex = 53;
            this.ModifyProductMax.TextChanged += new System.EventHandler(this.ModifyProductMaxTextBox);
            // 
            // ModifyProductPrice
            // 
            this.ModifyProductPrice.Location = new System.Drawing.Point(132, 335);
            this.ModifyProductPrice.Name = "ModifyProductPrice";
            this.ModifyProductPrice.Size = new System.Drawing.Size(280, 22);
            this.ModifyProductPrice.TabIndex = 51;
            this.ModifyProductPrice.TextChanged += new System.EventHandler(this.ModifyProductPriceTextBox);
            // 
            // ModifyProductInventory
            // 
            this.ModifyProductInventory.Location = new System.Drawing.Point(132, 276);
            this.ModifyProductInventory.Name = "ModifyProductInventory";
            this.ModifyProductInventory.Size = new System.Drawing.Size(280, 22);
            this.ModifyProductInventory.TabIndex = 50;
            this.ModifyProductInventory.TextChanged += new System.EventHandler(this.ModifyProductInventoryTextBox);
            // 
            // ModifyProductName
            // 
            this.ModifyProductName.Location = new System.Drawing.Point(132, 223);
            this.ModifyProductName.Name = "ModifyProductName";
            this.ModifyProductName.Size = new System.Drawing.Size(280, 22);
            this.ModifyProductName.TabIndex = 49;
            this.ModifyProductName.TextChanged += new System.EventHandler(this.ModifyProductNameTextBox);
            // 
            // ModifyProductID
            // 
            this.ModifyProductID.Location = new System.Drawing.Point(132, 172);
            this.ModifyProductID.Name = "ModifyProductID";
            this.ModifyProductID.Size = new System.Drawing.Size(280, 22);
            this.ModifyProductID.TabIndex = 48;
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(261, 400);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(30, 17);
            this.label_min.TabIndex = 46;
            this.label_min.Text = "Min";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(81, 400);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(33, 17);
            this.label_max.TabIndex = 45;
            this.label_max.Text = "Max";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(42, 340);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(40, 17);
            this.label_price.TabIndex = 44;
            this.label_price.Text = "Price";
            // 
            // label_inventory
            // 
            this.label_inventory.AutoSize = true;
            this.label_inventory.Location = new System.Drawing.Point(48, 281);
            this.label_inventory.Name = "label_inventory";
            this.label_inventory.Size = new System.Drawing.Size(66, 17);
            this.label_inventory.TabIndex = 43;
            this.label_inventory.Text = "Inventory";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(69, 228);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 42;
            this.label_name.Text = "Name";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(93, 177);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 17);
            this.label_ID.TabIndex = 41;
            this.label_ID.Text = "ID";
            // 
            // label_modprod
            // 
            this.label_modprod.AutoSize = true;
            this.label_modprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modprod.Location = new System.Drawing.Point(32, 22);
            this.label_modprod.Name = "label_modprod";
            this.label_modprod.Size = new System.Drawing.Size(149, 24);
            this.label_modprod.TabIndex = 38;
            this.label_modprod.Text = "Modify Product";
            // 
            // AllPartsGrid
            // 
            this.AllPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsGrid.Location = new System.Drawing.Point(467, 74);
            this.AllPartsGrid.Name = "AllPartsGrid";
            this.AllPartsGrid.RowHeadersWidth = 51;
            this.AllPartsGrid.RowTemplate.Height = 24;
            this.AllPartsGrid.Size = new System.Drawing.Size(463, 182);
            this.AllPartsGrid.TabIndex = 57;
            this.AllPartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPartsGrid_CellClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(863, 262);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(67, 28);
            this.btnAddProduct.TabIndex = 59;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddClick);
            // 
            // ModifyProductSearch
            // 
            this.ModifyProductSearch.Location = new System.Drawing.Point(740, 13);
            this.ModifyProductSearch.Name = "ModifyProductSearch";
            this.ModifyProductSearch.Size = new System.Drawing.Size(190, 22);
            this.ModifyProductSearch.TabIndex = 60;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(656, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 28);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // label_candparts
            // 
            this.label_candparts.AutoSize = true;
            this.label_candparts.Location = new System.Drawing.Point(464, 54);
            this.label_candparts.Name = "label_candparts";
            this.label_candparts.Size = new System.Drawing.Size(128, 17);
            this.label_candparts.TabIndex = 62;
            this.label_candparts.Text = "All Candidate Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Parts Associated with this Product";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(845, 509);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(85, 28);
            this.button_delete.TabIndex = 64;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // PartsProductGrid
            // 
            this.PartsProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsProductGrid.Location = new System.Drawing.Point(467, 321);
            this.PartsProductGrid.Name = "PartsProductGrid";
            this.PartsProductGrid.RowHeadersWidth = 51;
            this.PartsProductGrid.RowTemplate.Height = 24;
            this.PartsProductGrid.Size = new System.Drawing.Size(463, 182);
            this.PartsProductGrid.TabIndex = 63;
            this.PartsProductGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsProductGrid_CellClick);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.PartsProductGrid);
            this.Controls.Add(this.label_candparts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ModifyProductSearch);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.AllPartsGrid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ModifyProductMin);
            this.Controls.Add(this.ModifyProductMax);
            this.Controls.Add(this.ModifyProductPrice);
            this.Controls.Add(this.ModifyProductInventory);
            this.Controls.Add(this.ModifyProductName);
            this.Controls.Add(this.ModifyProductID);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_inventory);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_modprod);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProductForm";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsProductGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox ModifyProductMin;
        private System.Windows.Forms.TextBox ModifyProductMax;
        private System.Windows.Forms.TextBox ModifyProductPrice;
        private System.Windows.Forms.TextBox ModifyProductInventory;
        private System.Windows.Forms.TextBox ModifyProductName;
        private System.Windows.Forms.TextBox ModifyProductID;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_inventory;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_modprod;
        private System.Windows.Forms.DataGridView AllPartsGrid;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox ModifyProductSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label_candparts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView PartsProductGrid;
    }
}