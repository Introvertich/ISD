using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Converter
    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public double GRN { get; set; }


        public Converter()
        {
            USD = 0;
            EUR = 0;
            RUB = 0;
        }
        public Converter(double usd,double eur,double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double Convert(int currency, double amount)
        {
            switch(currency){
                //dollar to hryvna
                case 1:
                    return amount * USD;
                //euro to hryvna
                case 2:
                    return amount * EUR;
                //ruble to hryvna
                case 3:
                    return amount * RUB;
                //hryvna to dollar
                case 4:
                    return amount / USD;
                //hryvna to euro
                case 5:
                    return amount / EUR;
                //hryvna to ruble
                case 6:
                    return amount / RUB;
                default:
                    Console.WriteLine("Вы ввели некорректное значение!");
                    return -1;
                     

            }
        }

    }
}
