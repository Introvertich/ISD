using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayCalculator();
            Console.ReadLine();
        }
        static void BirthdayCalculator()
        {
            Console.WriteLine("Введите дату вашего рождения в формате ГГГГ.ММ.ДД:");
            string[] birthday = Console.ReadLine().Split('.');
            try
            {
                DateTime date = new DateTime(Convert.ToInt32(birthday[0]), Convert.ToInt32(birthday[1]), Convert.ToInt32(birthday[2]));
                DateTime ng = new DateTime(DateTime.Now.Year, 12, 31);
                int ostDay = date.DayOfYear - DateTime.Now.DayOfYear;
                int age = DateTime.Now.Year - date.Year;
                if (date.Year > DateTime.Now.Year)
                    throw new Exception();
                else if (ostDay < 0)
                {
                    ostDay = ng.DayOfYear - DateTime.Now.DayOfYear + date.DayOfYear;
                    age++;
                }
                Console.WriteLine($"До вашего следующего дня рождения осталось {ostDay} дней!\nВам исполняется {age} лет, Вы ещё так молоды!");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте ещё!");
                BirthdayCalculator();
            }
        }
    }
}
