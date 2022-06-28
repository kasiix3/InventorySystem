
namespace C968_Software_1
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.AddProductGrid = new System.Windows.Forms.DataGridView();
            this.label_candparts = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.AddProductSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.AddPartGrid = new System.Windows.Forms.DataGridView();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.AddProductMin = new System.Windows.Forms.TextBox();
            this.AddProductMax = new System.Windows.Forms.TextBox();
            this.AddProductPrice = new System.Windows.Forms.TextBox();
            this.AddProductInventory = new System.Windows.Forms.TextBox();
            this.AddProductName = new System.Windows.Forms.TextBox();
            this.AddProductIDTextBox = new System.Windows.Forms.TextBox();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_inventory = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_addprod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Parts Associated with this Product";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(853, 509);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(77, 28);
            this.button_delete.TabIndex = 87;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // AddProductGrid
            // 
            this.AddProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProductGrid.Location = new System.Drawing.Point(467, 321);
            this.AddProductGrid.Name = "AddProductGrid";
            this.AddProductGrid.RowHeadersWidth = 51;
            this.AddProductGrid.RowTemplate.Height = 24;
            this.AddProductGrid.Size = new System.Drawing.Size(463, 182);
            this.AddProductGrid.TabIndex = 86;
            this.AddProductGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddProductGrid_CellClick);
            // 
            // label_candparts
            // 
            this.label_candparts.AutoSize = true;
            this.label_candparts.Location = new System.Drawing.Point(464, 54);
            this.label_candparts.Name = "label_candparts";
            this.label_candparts.Size = new System.Drawing.Size(128, 17);
            this.label_candparts.TabIndex = 85;
            this.label_candparts.Text = "All Candidate Parts";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(656, 10);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(78, 28);
            this.button_search.TabIndex = 84;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // AddProductSearch
            // 
            this.AddProductSearch.Location = new System.Drawing.Point(740, 13);
            this.AddProductSearch.Name = "AddProductSearch";
            this.AddProductSearch.Size = new System.Drawing.Size(190, 22);
            this.AddProductSearch.TabIndex = 83;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(871, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 28);
            this.btnAdd.TabIndex = 82;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // AddPartGrid
            // 
            this.AddPartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddPartGrid.Location = new System.Drawing.Point(467, 74);
            this.AddPartGrid.Name = "AddPartGrid";
            this.AddPartGrid.RowHeadersWidth = 51;
            this.AddPartGrid.RowTemplate.Height = 24;
            this.AddPartGrid.Size = new System.Drawing.Size(463, 182);
            this.AddPartGrid.TabIndex = 81;
            this.AddPartGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddPartGrid_CellClick);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(863, 562);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(67, 37);
            this.button_cancel.TabIndex = 80;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(768, 562);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(67, 37);
            this.button_save.TabIndex = 79;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // AddProductMin
            // 
            this.AddProductMin.Location = new System.Drawing.Point(307, 397);
            this.AddProductMin.Name = "AddProductMin";
            this.AddProductMin.Size = new System.Drawing.Size(105, 22);
            this.AddProductMin.TabIndex = 78;
            this.AddProductMin.TextChanged += new System.EventHandler(this.AddProductMinTextBox);
            // 
            // AddProductMax
            // 
            this.AddProductMax.Location = new System.Drawing.Point(132, 400);
            this.AddProductMax.Name = "AddProductMax";
            this.AddProductMax.Size = new System.Drawing.Size(105, 22);
            this.AddProductMax.TabIndex = 77;
            this.AddProductMax.TextChanged += new System.EventHandler(this.AddProductMaxTextBox);
            // 
            // AddProductPrice
            // 
            this.AddProductPrice.Location = new System.Drawing.Point(132, 335);
            this.AddProductPrice.Name = "AddProductPrice";
            this.AddProductPrice.Size = new System.Drawing.Size(280, 22);
            this.AddProductPrice.TabIndex = 76;
            this.AddProductPrice.TextChanged += new System.EventHandler(this.AddProductPriceTextBox);
            // 
            // AddProductInventory
            // 
            this.AddProductInventory.Location = new System.Drawing.Point(132, 276);
            this.AddProductInventory.Name = "AddProductInventory";
            this.AddProductInventory.Size = new System.Drawing.Size(280, 22);
            this.AddProductInventory.TabIndex = 75;
            this.AddProductInventory.TextChanged += new System.EventHandler(this.AddProductInventoryTextBox);
            // 
            // AddProductName
            // 
            this.AddProductName.Location = new System.Drawing.Point(132, 223);
            this.AddProductName.Name = "AddProductName";
            this.AddProductName.Size = new System.Drawing.Size(280, 22);
            this.AddProductName.TabIndex = 74;
            this.AddProductName.TextChanged += new System.EventHandler(this.AddProductNameTextBox);
            // 
            // AddProductIDTextBox
            // 
            this.AddProductIDTextBox.Location = new System.Drawing.Point(132, 172);
            this.AddProductIDTextBox.Name = "AddProductIDTextBox";
            this.AddProductIDTextBox.Size = new System.Drawing.Size(280, 22);
            this.AddProductIDTextBox.TabIndex = 73;
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(261, 400);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(30, 17);
            this.label_min.TabIndex = 72;
            this.label_min.Text = "Min";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(81, 400);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(33, 17);
            this.label_max.TabIndex = 71;
            this.label_max.Text = "Max";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(42, 340);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(72, 17);
            this.label_price.TabIndex = 70;
            this.label_price.Text = "Price/Cost";
            // 
            // label_inventory
            // 
            this.label_inventory.AutoSize = true;
            this.label_inventory.Location = new System.Drawing.Point(48, 281);
            this.label_inventory.Name = "label_inventory";
            this.label_inventory.Size = new System.Drawing.Size(66, 17);
            this.label_inventory.TabIndex = 69;
            this.label_inventory.Text = "Inventory";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(69, 228);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 68;
            this.label_name.Text = "Name";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(93, 177);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 17);
            this.label_ID.TabIndex = 67;
            this.label_ID.Text = "ID";
            // 
            // label_addprod
            // 
            this.label_addprod.AutoSize = true;
            this.label_addprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addprod.Location = new System.Drawing.Point(32, 22);
            this.label_addprod.Name = "label_addprod";
            this.label_addprod.Size = new System.Drawing.Size(126, 24);
            this.label_addprod.TabIndex = 66;
            this.label_addprod.Text = "Add Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.AddProductGrid);
            this.Controls.Add(this.label_candparts);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.AddProductSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.AddPartGrid);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.AddProductMin);
            this.Controls.Add(this.AddProductMax);
            this.Controls.Add(this.AddProductPrice);
            this.Controls.Add(this.AddProductInventory);
            this.Controls.Add(this.AddProductName);
            this.Controls.Add(this.AddProductIDTextBox);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_inventory);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_addprod);
            this.Name = "AddProduct";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.AddProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPartGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView AddProductGrid;
        private System.Windows.Forms.Label label_candparts;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox AddProductSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView AddPartGrid;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox AddProductMin;
        private System.Windows.Forms.TextBox AddProductMax;
        private System.Windows.Forms.TextBox AddProductPrice;
        private System.Windows.Forms.TextBox AddProductInventory;
        private System.Windows.Forms.TextBox AddProductName;
        private System.Windows.Forms.TextBox AddProductIDTextBox;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_inventory;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_addprod;
    }
}