using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker dw;
            string key;
            Console.Write("Введите ключь для доступап к версии Pro или Expert: ");
            key = Console.ReadLine();
            if (key.Equals(new ProDocmentWorker().Key))
            {
                Console.WriteLine("Вы используете версию Pro!");
                dw = new ProDocmentWorker();
            }
            else if (key.Equals(new ExpertDocumentWorker().Key))
            {
                Console.WriteLine("Вы используете версию Expert!");
                dw = new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("Вы используете стандартную версию редактора!");
                dw = new DocumentWorker();
            }
            Console.ReadKey();
        }
    }
}