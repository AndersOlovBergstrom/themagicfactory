using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace themagicfactoryown
{
    public class Product : InventoryItem
    {
        public string SerialNumber { get; private set; }

        public Product(string name) : base(name)
        {
            SerialNumber = new Guid().ToString();
        }
    }
}
