using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue, max = int.MinValue;
            int[] array = {};
            Console.WriteLine("Length of the array");
            int lenght = int.Parse(Console.ReadLine());
            array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Number: " + (i + 1));
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------");
            foreach (int number in array)
            {
                Console.WriteLine(number);
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine("Smallest number: " + (min));
            Console.WriteLine("Biggest number: " + (max));
            Console.ReadKey();
        }
    }
}
