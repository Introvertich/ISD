using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Title
    {
        string bookName;
        public string BookName { get; set; }
        public void Show()
        {
            Console.WriteLine("Название книги: "+BookName);
        }
    }
}
