using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class ExpertDocumentWorker : ProDocmentWorker
    {
        public new string Key { get; } = "ExpertKey";
        
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
