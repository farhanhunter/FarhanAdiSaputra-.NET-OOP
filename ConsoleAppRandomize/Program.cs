using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRandomize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNumber = rand.Next(1, 11);

            Console.WriteLine("Tebak angka antara 1 - 10 :");

            while (true)
            {
                string? userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int userGuess))
                {
                    if (userGuess == randNumber)
                    {
                        Console.WriteLine("Tebakan Benar");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tebakan Salah");
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid, masukan angka yang sesuai");
                }
            }
        }
    }
}
