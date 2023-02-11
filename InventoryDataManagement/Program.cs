namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Inventory Data Management!!!");  
            DataInventortyManagement management = new DataInventortyManagement();
            management.GetData();
        }
    }
}