using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Content
    {
        public string BookContent { get; set; }
        public void Show()
        {
            Console.WriteLine("Содержание книги: "+BookContent);
        }
    }
}
