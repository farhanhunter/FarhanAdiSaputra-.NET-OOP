using System;

namespace Inheritance
{
    public class Lingkaran
    {
        double luas;

        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;
        }
    }
    public class Tabung : Lingkaran
    {
        double volume;
        public Tabung(int tinggi, double r)
        {
            volume = tinggi * this.LuasLingkaran(r);
        }
        public double getVolume()
        {
            return volume;
        }
        static void Main(string[] args)
        {
            Tabung tabung = new Tabung(5,10);

            Console.WriteLine($"Volume = {tabung.getVolume()}");
        }
    }
}