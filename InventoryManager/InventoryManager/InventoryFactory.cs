using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class InventoryFactory
    {
        public List<InventoryItems> wheat { get; set; }
        public List<InventoryItems> rice { get; set; }
        public List<InventoryItems> pulses { get; set; }
    }
}
