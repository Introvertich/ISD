using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Mark", "Zuckerberg");
            e.Position = Position.Senior;
            e.Experience = 10;

            Console.WriteLine("Name: {0}\nSurname: {1}\nPosition: {2}", e.Name, e.Surname, e.Position);
            e.CalculateSalary();

            Console.ReadLine();
        }
    }
}
