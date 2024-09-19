using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    public class Customer : User
    {
        public Customer(string nama, double saldo) : base(nama, "Customer", saldo) { }
        public void checkMoney()
        {
            Console.WriteLine($"Saldo {Nama}: {Saldo}");
        }
    }
}
