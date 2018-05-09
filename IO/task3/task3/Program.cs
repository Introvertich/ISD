using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Program
    {
        static void Menu(string path)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Write to file \n2. Read from file \n3. Exit");
                switch (Console.ReadLine())
                {
                    case "1": WriteFile(path); break;
                    case "2": ReadFile(path); break;
                    case "3": return;
                    default:  break;
                }
            } while (true);
        }

        private static void WriteFile(string path)
        {
            Console.Write("Enter string to write in file: ");
            string data = Console.ReadLine();
            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
            {
                byte[] dataB = new UTF8Encoding(true).GetBytes(data);
                fs.Write(dataB, 0, dataB.Length);
            }
        }

        private static void ReadFile(string path)
        {
            string data = "";
            if (File.Exists(path))
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    byte[] dataB = new byte[fs.Length];
                    fs.Read(dataB, 0, dataB.Length);
                    data = Encoding.UTF8.GetString(dataB);
                }
            Console.WriteLine(data);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Console.Clear();
            string path = @"C:\Users\" + Environment.UserName + @"\Documents";
            Console.Write("Enter the name of file, you want to find: ");
            string fileName = path + @"\" + Console.ReadLine() + ".txt";
            Menu(fileName);
        }
    }
}
