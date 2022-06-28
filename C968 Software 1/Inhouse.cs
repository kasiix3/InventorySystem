using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Software_1
{
    class Inhouse : Part
    {
        
        public int MachineID { get; set; }

        public Inhouse() { }
                    
        public Inhouse(int partID, string name, int inStock, decimal price, int max, int min, int machineID) : base(partID, name, inStock, price, max, min)
        {
            MachineID = machineID;

        }
    }
}
