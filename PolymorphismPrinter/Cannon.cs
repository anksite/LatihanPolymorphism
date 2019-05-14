using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    class Cannon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Cannon display dimension: 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Cannon printer printing....");
        }
    }
}
