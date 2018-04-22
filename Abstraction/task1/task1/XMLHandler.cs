using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Введите название файла (без маски):");
            string name = Console.ReadLine();

            Console.WriteLine("Введите текст для записи в файл:");
            string text = Console.ReadLine();
            try
            {
                using (FileStream fstream = new FileStream(name + ".xml", FileMode.Open))
                {
                    byte[] array = Encoding.Default.GetBytes(text);
                    fstream.Write(array, 0, array.Length);
                    Console.WriteLine("Текст записан в файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void Create()
        {
            Console.WriteLine("Введите название файла (без маски):");
            string name = Console.ReadLine();
            FileInfo fname = new FileInfo(name + ".xml");
            using (FileStream fstream = fname.Create())
            Console.WriteLine($"Файл {name}.xml создан!");
        }

        public override void Open()
        {
            Console.WriteLine("Введите название файла (без маски):");
            string name = Console.ReadLine();
            try
            {
                using (FileStream fstream = File.OpenRead(name + ".xml"))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    string textFromFile = Encoding.Default.GetString(array);
                    Console.WriteLine("Текст из файла:\n{0}", textFromFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void Save()
        {
            // Метод Save() нужен по заданию, но ведь файлы сами сохраняются после их создания/редактирования...
            Console.WriteLine("Метод Save().");
        }
    }
}
