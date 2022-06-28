using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Software_1
{
    class Inventory
    {
        //Binding Lists
        
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }
        
        private static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Part> Parts { get { return parts; } set { Parts = value; } }

        //Part Constructors
        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }

        //Product Constructors
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }

        //Associated Parts Constructors
        public static int CurrentAssociatedIndex { get; set; }
        public static Part CurrentAssociatedPart { get; set; }

        //Products Methods

        //Add Product
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //Remove Product
        public static bool RemoveProduct(int index)
        {
            Products.RemoveAt(index);
            return true;
        
        }
        //Look up Product
        public static Product LookUpProduct(int productID)
        {
            foreach(Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            return null;
  
        }
        //Update Product
        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            Inventory.RemoveProduct(CurrentProductIndex);
            Inventory.AddProduct(CurrentProduct);
        }
        //Parts Methods
        //Add Part
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }
        //Remove Part
              
        public static bool DeletePart(Part part)
        {
            try
            {
                Parts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Look up Part
        public static Part LookUpPart(int partID)
        {
            foreach(Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;

        }
        public static int createPartID()
        {
            int maxID = 0;
            foreach (Part part in Parts)
            {
                if (part.PartID > maxID)
                    maxID = part.PartID;
            }
            return maxID + 1;
        }
        public static int createProductID()
        {
            int maxID = 0;
            foreach (Product product in Products)
            {
                if (product.ProductID > maxID)
                    maxID = product.ProductID;
            }
            return maxID + 1;
        }

        //Update Part
        public static void UpdatePart(int partID, Part part)
        {
            Inventory.DeletePart(part);
            Inventory.AddPart(part);
        }
       
    }
}
