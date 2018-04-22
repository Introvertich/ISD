using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

            Console.ReadLine();
        }

        static void MainMenu()
        {
            Console.WriteLine("Выберите формат файла:\n1) .xml\n2) .txt\n3) .doc");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SubMenu(1);
                    break;
                case "2":
                    SubMenu(2);
                    break;
                case "3":
                    SubMenu(3);
                    break;
                default:
                    Console.WriteLine("Выберите вариант из предложенных!");
                    MainMenu();
                    break;
            }
        }

        static void SubMenu(int i)
        {
            Console.WriteLine("Выберите действие с файлом:\n1) Создание.\n2) Открытие.\n3) Редактирование.\n4) Сохранение.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    switch(i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Create();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Create();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Create();
                            break;
                    }
                    MainMenu();
                    break;
                case "2":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Open();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Open();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Open();
                            break;
                    }
                    MainMenu();
                    break;
                case "3":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Change();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Change();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Change();
                            break;
                    }
                    MainMenu();
                    break;
                case "4":
                    switch (i)
                    {
                        case 1:
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.Save();
                            break;
                        case 2:
                            TXTHandler xtxHandler = new TXTHandler();
                            xtxHandler.Save();
                            break;
                        case 3:
                            DOCHandler docHandler = new DOCHandler();
                            docHandler.Save();
                            break;
                    }
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Выберите вариант из предложенных!");
                    SubMenu(i);
                    break;
            }
        }

    }
}
