using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    class DataInventortyManagement
    {
        public void GetData()
        {
            string filepath = @"C:\Users\RINKU\Desktop\Day6\InventoryDataManagement\InventoryDataManagement\DataInventory.json";
            try
            {
                if (File.Exists(filepath))
                {
                    string inverntoryData = File.ReadAllText(filepath);
                    Root root = JsonConvert.DeserializeObject<Root>(inverntoryData);
                    List<Inventory> inventories = root.inventories;
                    foreach (Inventory inventory in inventories)
                    {
                        Console.WriteLine($" Name: {inventory.Name} \n Weight: {inventory.Weight} \n Price: {inventory.Price} \n");
                    }
                }
                else
                {
                    Console.WriteLine("File Not found");
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
