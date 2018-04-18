using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class MyPrinter:Printer
    {
        public MyPrinter()
        {
            Color = ConsoleColor.DarkGreen;
        }

        public MyPrinter(ConsoleColor color):base(color)
        {

        }
    }

    
}
