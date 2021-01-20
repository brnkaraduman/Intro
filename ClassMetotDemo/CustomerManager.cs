using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Banka Müşteri Listesi");
            Console.WriteLine("Müşteri Numarası :" + customer.CustomerId);
            Console.WriteLine("Müşteri Adi :" + customer.CustomerName);
            Console.WriteLine("Müşteri TC Kimlik No :" + customer.CustomerIdentityCardNo);
            Console.WriteLine("Müşteri Tipi :" + customer.CustomerType);
        }

        public void CustomerAdd(Customer customer1)
        {
            Console.WriteLine(customer1.CustomerName +" "+" Banka Müşteri Listesine Eklendi");
            
        }

        public void CustomerDelete(Customer customer2)
        {
            Console.WriteLine(customer2.CustomerName + " " + " Banka Müşteri Listesinden Silindi");

        }
    }
}
