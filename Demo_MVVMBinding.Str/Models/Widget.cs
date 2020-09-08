using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVVMBinding
{
    public class Widget : ObservableObject
    {
        public string  Name { get; set; }
        public string Color { get; set; }
        public double UnitPrice { get; set; }
        public int CurrentInventory { get; set; }
    }
}
