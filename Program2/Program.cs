using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Static_Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a car brand");
            string Brand = Console.ReadLine(); 
            string[] Cars = { "Jaguar", "Unique", "Pagani", "Campagna", "Alfa Romeo", "Elfin", "Ferrari", "NIE", "Volkswagen", "Suzuki", "Audi", "Opel", "Volvo", "Mitsubishi", "Lobini", "Maserati", "Callaway", "Seat", "Gumpert", "Chevrolet", "ChryslerLotus" };
            //bool has = Array.IndexOf(Cars, Brand) >= 0; //.toLowercase
            bool has = Cars.Contains(Brand);
            if (has)
            {
                Console.WriteLine("");
                Console.WriteLine("Found it");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Not here");
                Console.WriteLine("");
                Array.Sort(Cars);
                foreach (string s in Cars)
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey();
        }
    }
}
