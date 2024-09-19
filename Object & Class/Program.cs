using System;

namespace UserManagement
{
    class User
    {
        //atribute
        string nama = "Farhan";
        string role = "Backend";
        int emoney = 100000000;

        //method
        public void UserDetail()
        {
            Console.WriteLine("Ini detail usernya");
        }
        static void Main(string[] args)
        {
            User userBootcamp = new User();
            userBootcamp.UserDetail();
            Console.WriteLine("Nama : " + userBootcamp.nama);
            Console.WriteLine("Role : " + userBootcamp.role);
            Console.WriteLine("Uang Saku : " + userBootcamp.emoney);
        }
    }
}