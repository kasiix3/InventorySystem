using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Software_1
{
    class Product
    {
       
        public Product() {}
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set;}        
        public int Max { get; set; }
        public int Min { get; set; }

        
        public Product (int productID, string name, int inStock, decimal price, int max, int min)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
               try
                {
                    AssociatedParts.RemoveAt(partID);
                    return true;
                }
            catch (Exception)
            {
                return false;
            }
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach(Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

    }
}
