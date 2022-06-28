
namespace C968_Software_1
{
    partial class Main
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
            this.PartsGrid1 = new System.Windows.Forms.DataGridView();
            this.button_searchparts = new System.Windows.Forms.Button();
            this.label_parts = new System.Windows.Forms.Label();
            this.MainPartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.button_addparts = new System.Windows.Forms.Button();
            this.button_modifyparts = new System.Windows.Forms.Button();
            this.button_deleteparts = new System.Windows.Forms.Button();
            this.button_deleteproducts = new System.Windows.Forms.Button();
            this.button_modifyproducts = new System.Windows.Forms.Button();
            this.button_addproducts = new System.Windows.Forms.Button();
            this.MainProductsSearchTextBox = new System.Windows.Forms.TextBox();
            this.label_products = new System.Windows.Forms.Label();
            this.button_searchproducts = new System.Windows.Forms.Button();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.label_ims = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsGrid1
            // 
            this.PartsGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsGrid1.Location = new System.Drawing.Point(43, 99);
            this.PartsGrid1.Name = "PartsGrid1";
            this.PartsGrid1.RowHeadersWidth = 51;
            this.PartsGrid1.RowTemplate.Height = 24;
            this.PartsGrid1.Size = new System.Drawing.Size(470, 265);
            this.PartsGrid1.TabIndex = 0;
            this.PartsGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsGrid1_CellClick);
            // 
            // button_searchparts
            // 
            this.button_searchparts.BackColor = System.Drawing.Color.Snow;
            this.button_searchparts.Location = new System.Drawing.Point(251, 65);
            this.button_searchparts.Name = "button_searchparts";
            this.button_searchparts.Size = new System.Drawing.Size(79, 24);
            this.button_searchparts.TabIndex = 2;
            this.button_searchparts.Text = "Search";
            this.button_searchparts.UseVisualStyleBackColor = false;
            this.button_searchparts.Click += new System.EventHandler(this.btnSearchPartsClick);
            // 
            // label_parts
            // 
            this.label_parts.AutoSize = true;
            this.label_parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parts.Location = new System.Drawing.Point(40, 68);
            this.label_parts.Name = "label_parts";
            this.label_parts.Size = new System.Drawing.Size(43, 18);
            this.label_parts.TabIndex = 3;
            this.label_parts.Text = "Parts";
            // 
            // MainPartsSearchTextBox
            // 
            this.MainPartsSearchTextBox.Location = new System.Drawing.Point(338, 65);
            this.MainPartsSearchTextBox.Name = "MainPartsSearchTextBox";
            this.MainPartsSearchTextBox.Size = new System.Drawing.Size(175, 22);
            this.MainPartsSearchTextBox.TabIndex = 4;
            // 
            // button_addparts
            // 
            this.button_addparts.Location = new System.Drawing.Point(288, 370);
            this.button_addparts.Name = "button_addparts";
            this.button_addparts.Size = new System.Drawing.Size(71, 36);
            this.button_addparts.TabIndex = 5;
            this.button_addparts.Text = "Add";
            this.button_addparts.UseVisualStyleBackColor = true;
            this.button_addparts.Click += new System.EventHandler(this.btnAddPartsClick);
            // 
            // button_modifyparts
            // 
            this.button_modifyparts.Location = new System.Drawing.Point(365, 370);
            this.button_modifyparts.Name = "button_modifyparts";
            this.button_modifyparts.Size = new System.Drawing.Size(71, 36);
            this.button_modifyparts.TabIndex = 6;
            this.button_modifyparts.Text = "Modify";
            this.button_modifyparts.UseVisualStyleBackColor = true;
            this.button_modifyparts.Click += new System.EventHandler(this.btnModifyPartsClick);
            // 
            // button_deleteparts
            // 
            this.button_deleteparts.Location = new System.Drawing.Point(442, 370);
            this.button_deleteparts.Name = "button_deleteparts";
            this.button_deleteparts.Size = new System.Drawing.Size(71, 36);
            this.button_deleteparts.TabIndex = 7;
            this.button_deleteparts.Text = "Delete";
            this.button_deleteparts.UseVisualStyleBackColor = true;
            this.button_deleteparts.Click += new System.EventHandler(this.btnDeletePartsClick);
            // 
            // button_deleteproducts
            // 
            this.button_deleteproducts.Location = new System.Drawing.Point(969, 370);
            this.button_deleteproducts.Name = "button_deleteproducts";
            this.button_deleteproducts.Size = new System.Drawing.Size(71, 36);
            this.button_deleteproducts.TabIndex = 14;
            this.button_deleteproducts.Text = "Delete";
            this.button_deleteproducts.UseVisualStyleBackColor = true;
            this.button_deleteproducts.Click += new System.EventHandler(this.btnDeleteProductsClick);
            // 
            // button_modifyproducts
            // 
            this.button_modifyproducts.Location = new System.Drawing.Point(892, 370);
            this.button_modifyproducts.Name = "button_modifyproducts";
            this.button_modifyproducts.Size = new System.Drawing.Size(71, 36);
            this.button_modifyproducts.TabIndex = 13;
            this.button_modifyproducts.Text = "Modify";
            this.button_modifyproducts.UseVisualStyleBackColor = true;
            this.button_modifyproducts.Click += new System.EventHandler(this.btnModifyProductsClick);
            // 
            // button_addproducts
            // 
            this.button_addproducts.Location = new System.Drawing.Point(815, 370);
            this.button_addproducts.Name = "button_addproducts";
            this.button_addproducts.Size = new System.Drawing.Size(71, 36);
            this.button_addproducts.TabIndex = 12;
            this.button_addproducts.Text = "Add";
            this.button_addproducts.UseVisualStyleBackColor = true;
            this.button_addproducts.Click += new System.EventHandler(this.btnAddProductsClick);
            // 
            // MainProductsSearchTextBox
            // 
            this.MainProductsSearchTextBox.Location = new System.Drawing.Point(865, 65);
            this.MainProductsSearchTextBox.Name = "MainProductsSearchTextBox";
            this.MainProductsSearchTextBox.Size = new System.Drawing.Size(175, 22);
            this.MainProductsSearchTextBox.TabIndex = 11;
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_products.Location = new System.Drawing.Point(567, 68);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(68, 18);
            this.label_products.TabIndex = 10;
            this.label_products.Text = "Products";
            // 
            // button_searchproducts
            // 
            this.button_searchproducts.Location = new System.Drawing.Point(778, 65);
            this.button_searchproducts.Name = "button_searchproducts";
            this.button_searchproducts.Size = new System.Drawing.Size(79, 24);
            this.button_searchproducts.TabIndex = 9;
            this.button_searchproducts.Text = "Search";
            this.button_searchproducts.UseVisualStyleBackColor = true;
            this.button_searchproducts.Click += new System.EventHandler(this.btnSearchProductsClick);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Location = new System.Drawing.Point(570, 99);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowHeadersWidth = 51;
            this.ProductsGrid.RowTemplate.Height = 24;
            this.ProductsGrid.Size = new System.Drawing.Size(470, 265);
            this.ProductsGrid.TabIndex = 8;
            this.ProductsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellClick);
            // 
            // label_ims
            // 
            this.label_ims.AutoSize = true;
            this.label_ims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ims.Location = new System.Drawing.Point(38, 19);
            this.label_ims.Name = "label_ims";
            this.label_ims.Size = new System.Drawing.Size(310, 25);
            this.label_ims.TabIndex = 15;
            this.label_ims.Text = "Inventory Management System";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(969, 429);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(70, 34);
            this.button_exit.TabIndex = 16;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 492);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_ims);
            this.Controls.Add(this.button_deleteproducts);
            this.Controls.Add(this.button_modifyproducts);
            this.Controls.Add(this.button_addproducts);
            this.Controls.Add(this.MainProductsSearchTextBox);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.button_searchproducts);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.button_deleteparts);
            this.Controls.Add(this.button_modifyparts);
            this.Controls.Add(this.button_addparts);
            this.Controls.Add(this.MainPartsSearchTextBox);
            this.Controls.Add(this.label_parts);
            this.Controls.Add(this.button_searchparts);
            this.Controls.Add(this.PartsGrid1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.PartsGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartsGrid1;
        private System.Windows.Forms.Button button_searchparts;
        private System.Windows.Forms.Label label_parts;
        private System.Windows.Forms.TextBox MainPartsSearchTextBox;
        private System.Windows.Forms.Button button_addparts;
        private System.Windows.Forms.Button button_modifyparts;
        private System.Windows.Forms.Button button_deleteparts;
        private System.Windows.Forms.Button button_deleteproducts;
        private System.Windows.Forms.Button button_modifyproducts;
        private System.Windows.Forms.Button button_addproducts;
        private System.Windows.Forms.TextBox MainProductsSearchTextBox;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.Button button_searchproducts;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.Label label_ims;
        private System.Windows.Forms.Button button_exit;
    }
}