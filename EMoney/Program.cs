using System;

namespace EMoney
{
    // Kelas dasar User
    public class User
    {
        private string nama;
        private decimal emoney;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public decimal Emoney
        {
            get { return emoney; }
            protected set { emoney = value; }
        }

        public User(string nama, decimal saldoAwal)
        {
            this.nama = nama;
            this.emoney = saldoAwal;
        }

        public virtual void LihatSaldo()
        {
            Console.WriteLine($"Saldo E-Money {nama}: {emoney:C}");
        }
    }

    // Kelas Admin, turunan dari User
    public class Admin : User
    {
        public Admin(string nama, decimal saldoAwal) : base(nama, saldoAwal) { }

        public void TambahSaldoCustomer(Customer customer, decimal jumlah)
        {
            customer.Emoney += jumlah;
            Console.WriteLine($"Admin {nama} menambahkan saldo {jumlah:C} ke akun {customer.Nama}");
        }
    }

    // Kelas Customer, turunan dari User
    public class Customer : User
    {
        public Customer(string nama, decimal saldoAwal) : base(nama, saldoAwal) { }

        // Customer hanya bisa melihat saldo, fungsi ini sudah diwarisi dari kelas User
    }

    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Admin1", 1000000);
            Customer customer1 = new Customer("Customer1", 50000);
            Customer customer2 = new Customer("Customer2", 75000);

            Console.WriteLine("Saldo awal:");
            customer1.LihatSaldo();
            customer2.LihatSaldo();

            admin.TambahSaldoCustomer(customer1, 25000);
            admin.TambahSaldoCustomer(customer2, 50000);

            Console.WriteLine("\nSaldo setelah penambahan:");
            customer1.LihatSaldo();
            customer2.LihatSaldo();
        }
    }
}