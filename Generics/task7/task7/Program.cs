using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myarr = new ArrayList(new object[] {"new interface",12,17,'a' });
            Console.WriteLine("ArrayList after creating and filling:");
            for(int i=0;i<myarr.Size;i++)
            {
                Console.WriteLine(myarr[i]); 
            }
            myarr.Clear();
            myarr.AddRange(new object[] { 'b', 13, 42, "Kotlin" });
            Console.WriteLine("ArrayList after clearing and adding range:");
            for (int i = 0; i < myarr.Size; i++)
            {
                Console.WriteLine(myarr[i]);
            }
            myarr.Remove(1);
            Console.WriteLine("After removing element with index 1:");
            for (int i = 0; i < myarr.Size; i++)
            {
                Console.WriteLine(myarr[i]);
            }
            myarr.Reverse();
            Console.WriteLine("After revercing:");
            for (int i = 0; i < myarr.Size; i++)
            {
                Console.WriteLine(myarr[i]);
            }
            
            object[] arr = new object[] { };
            arr=myarr.CopyTo(1);
            Console.WriteLine("Copying ArrayList into array of objects from 1 index:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
