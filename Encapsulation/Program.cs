using System;

namespace Encapsulation
{
    public class Lingkaran
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih dari nol");
                }
            }

        }
        public double LuasLingkaran()
        {
            return 3.14 * radius * radius;
        }
        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;

            public Tabung(double radius, double tinggi)
            {
                lingkaran = new Lingkaran();
                lingkaran.Radius = radius;
                this.tinggi = tinggi;
            }

            public double HitungVolume()
            {
                return lingkaran.LuasLingkaran() * tinggi;
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Tabung tabung = new Tabung(-2, 6);
                    Console.WriteLine($"tabung.HitungVolume()");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        }
        }
    }
   
}

// E-Money
// Buat kelas
// 1. User
// 2. Admin
// 3. Customer

// Attribute dari kelas user
// nama : menyimpan nama pengguna
// emoney : menyimpan saldo pengguna

// Admin dan Customer untuk merupakan kelas turunan dari USer
// Admin itu bisa nambah saldo customer
// Customer dia cuman bisa lihat saldo aja
