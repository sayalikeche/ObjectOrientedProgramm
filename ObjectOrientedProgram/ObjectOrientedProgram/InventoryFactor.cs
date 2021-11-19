using Objectorientedprogram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogram
{
    internal class InventoryFactory
    {
        public List<InventoryStockModel> Rice { get; set; }
        public List<InventoryStockModel> Wheat { get; set; }
        public List<InventoryStockModel> Pulses { get; set; }

        public class InventoryStockModel
        {
        }
    }
}