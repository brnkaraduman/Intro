using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 123456;
            customer1.CustomerName = "Ali VELİ";
            customer1.CustomerIdentityCardNo = 1234567891;
            customer1.CustomerType = "Company";

            Customer customer2 = new Customer();
            customer2.CustomerId = 456789;
            customer2.CustomerName = "Ali OSMAN";
            customer2.CustomerIdentityCardNo = 1987654321;
            customer2.CustomerType = "Factory";

            Customer[] customerarray = new Customer[] { customer1, customer2 };

            //Müşteri Listeleme
            Console.WriteLine("-------------Müşteri Listelesi----------------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerList(customer1);
            Console.WriteLine(" ");
            customerManager.CustomerList(customer2);
            //Müşteri Ekle
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" ");
            customerManager.CustomerAdd(customer1);

            //Müşteri Sil
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" ");
            customerManager.CustomerDelete(customer2);
        }
    }
}
