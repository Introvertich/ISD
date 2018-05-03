using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteIn();
            ReadOut();

            Console.ReadLine();
        }

        static void WriteIn()
        {
            Console.WriteLine("Введите текст для записи в файл:");
            string text = Console.ReadLine();

            try
            {
                using (FileStream fstream = new FileStream("newFile.txt", FileMode.Create))
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

        static void ReadOut()
        {
            try
            {
                using (FileStream fstream = File.OpenRead("newFile.txt"))
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
    }
}
