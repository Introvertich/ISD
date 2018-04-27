using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
        enum Position { QualityAssurance = 40, ProjectManager = 60, HumanResources = 80, SeniorDeveloper = 100}
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant acc = new Accauntant();
            Position senDeveloer = Position.SeniorDeveloper;
            Console.WriteLine(acc.AskForBonus(senDeveloer, 101) ? "Senior Developer has premium" : "Senior Developer hasnt premium");
            Console.ReadKey();
        }
    }
}
