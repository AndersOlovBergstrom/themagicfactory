using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace themagicfactoryown
{
    public class Material : InventoryItem
    {
        public Material(string name) : base(name)
        {
            Name = name;
        }
    }
}
