using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Software_1
{
    class Outsourced : Part
    {
        
        public string CompanyName { get; set; }

        //Constructor
        public Outsourced() { }
        public Outsourced(int partID, string  name, int inStock, decimal price, int max, int min, string companyName) : base (partID, name, inStock, price, max, min)
        {
            CompanyName = companyName;
        }
      
    }

}
