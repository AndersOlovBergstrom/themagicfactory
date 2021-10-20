using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace themagicfactoryown
{
    public class Warehouse : StoragePlace
    {
        public Warehouse()
        {
            Items = new List<InventoryItem>
            {
                new Material("Iron"),
                new Material("Iron"),
                new Material("Rubber"),
                new Material("Rubber"),
                new Material("Rubber"),
                new Material("Rubber"),
                new Material("Steel"),
                new Material("Steel"),
                new Material("Steel"),
                new Material("Steel"),
                new Material("Steel"),
            };
        }
    }
}
