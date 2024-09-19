using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bootcamp =
            {
                "Andi", "Budi", "Canteng", "Daffa"
            };
            var query = from n in bootcamp select n;
            foreach (string peserta in query)
            {
                Console.WriteLine(peserta);
            }
        }
    }
}

// program tebak2an angka randomize number 
