using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Software_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Inventory.Parts.Add(new Inhouse(1, "Windshield", 43, 570.5m, 100, 25, 52));
            Inventory.Parts.Add(new Inhouse(2, "Tailight", 26, 67.1m, 100, 25, 327));
            Inventory.Parts.Add(new Outsourced(5987, "Logo", 37, 325.3m, 100, 25, "Jeep"));
            Inventory.Parts.Add(new Outsourced(5789, "Tire", 28, 209.4m, 100, 25, "Michelin"));

            Inventory.Products.Add(new Product(13, "Jeep Wrangler", 2, 56000.99m, 10, 1));
            Inventory.Products.Add(new Product(7, "Ford Raptor", 1, 87000.00m, 10, 1));
            Inventory.Products.Add(new Product(11, "Chevy Camaro", 3, 49999.99m, 10, 1));
            Inventory.Products.Add(new Product(8, "Ford Bronco", 1, 40000.00m, 10, 1));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
