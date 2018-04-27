using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    struct Notebook
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        
        public Notebook(string Model, string Manufacturer, int Price)
        {
            this.Model = Model;
            this.Manufacturer = Manufacturer;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"Model = {Model};\nManufacturer = {Manufacturer};\nPrice = {Price}.\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Aspire", "Acer", 10000);

            Console.WriteLine(notebook.ToString());

            Console.ReadLine();
        }
    }
}
