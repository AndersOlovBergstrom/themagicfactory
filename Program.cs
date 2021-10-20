using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace themagicfactoryown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("It's a start!");

            bool programIsActive = true;
            var warehouse = new Warehouse();
            var factory = new Factory();

            while (programIsActive)
            {
                warehouse.ListInventory();

                Console.WriteLine("Let's send stock from Warehouse to Factory");

                List<InventoryItem> itemsToTransfer = warehouse.TransferAllItems();

                factory.AddItems(itemsToTransfer);

                factory.ListInventory();

                List<InventoryItem> leftovers = factory.RunFactoryAndReturnLeftovers();

                warehouse.AddItems(leftovers);
                warehouse.ListInventory();

                Console.ReadLine();

                // End
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    programIsActive = false;
                }
            }

        }
    }
}
