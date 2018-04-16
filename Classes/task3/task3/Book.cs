using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Book
    {
        public Content MyCont { get; set; }
        public Title MyTitle { get; set; }
        public Author MyAuthor { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            MyAuthor.Show();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            MyCont.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            MyTitle.Show();
        }
        public Book()
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
        }
        public Book(string autName,string bookTitle,string bookContent)
        {
            MyAuthor = new Author();
            MyTitle = new Title();
            MyCont = new Content();
            MyCont.BookContent = bookContent;
            MyAuthor.AutName = autName;
            MyTitle.BookName = bookTitle;
        }
    }
}
