using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class Inventory
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }
    }
    public class Root
    {
        public List<Inventory> inventories { get; set; }
    }
}
