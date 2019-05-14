using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Cannoc");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int noPrinter = Convert.ToInt32(Console.ReadLine());

            if (noPrinter==1) {
                printer = new Epson();
            }else if (noPrinter == 2){
                printer = new Cannon();
            }else {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
