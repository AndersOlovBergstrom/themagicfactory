using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace themagicfactoryown
{
    public abstract class InventoryItem
    {
        protected InventoryItem(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
    }
}
