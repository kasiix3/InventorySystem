using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Software_1
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private int inStock;
        private decimal price;
        private int max;
        private int min;

        public int PartID { get; set; }
        public string Name { get; set;}
        public int InStock { get; set;}
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
      
        public Part() { }
        public Part (int partID, string name, int inStock, decimal price, int max, int mix)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }

    }
}
