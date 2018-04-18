using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Printer
    {
        protected ConsoleColor Color;

        public Printer()
        {
            Color = ConsoleColor.Blue;
        }

        public Printer(ConsoleColor color)
        {
            Color = color;
        }

        public virtual void Print(string value)
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(value);
        }

    }
}
