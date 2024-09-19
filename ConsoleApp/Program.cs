using ConsoleAppCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + "\t");

                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nUsing foreach loop (with manual counter):");

            int counter = 0;
            foreach (int num in numbers)
            {
                Console.Write(num + "\t");
                counter++;

                if (counter % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
