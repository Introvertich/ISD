using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_5
{
    class Program
    {
        static void Main()
        {
            int today = Convert.ToInt32(DateTime.Today.DayOfWeek);
            Console.Write("Today is ");
            string day = "";
            switch (today)
            {
                case 0: day = "Sunday"; break;
                case 1: day = "Monday"; break;
                case 2: day = "Tuesday"; break;
                case 3: day = "Wednesday"; break;
                case 4: day = "Thursday"; break;
                case 5: day = "Friday"; break;
                case 6: day = "Saturday"; break;
            }
            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}
