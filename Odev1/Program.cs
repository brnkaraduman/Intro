using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.ProductId = 1001;
            p1.ProductName = "abcd";
            p1.ProductCountry = "Turkey";

            Product p2 = new Product();
            p2.ProductId = 1002;
            p2.ProductName = "efgh";
            p2.ProductCountry = "Chine";

            Product p3 = new Product();
            p3.ProductId = 1003;
            p3.ProductName = "klmn";
            p3.ProductCountry = "USA";


            Product[] products = new Product[] { p1, p2, p3 };

            Console.WriteLine("FOREACH");

            foreach( var product in products )
            {
                
                Console.WriteLine(product.ProductId + ":" + product.ProductName + "-" + product.ProductCountry );
            }

            Console.WriteLine("FOR");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductId +":"+ products[i].ProductName +"-"+ products[i].ProductCountry);
            }

            Console.WriteLine("WHILE");
            int p = 0;
            while (p<products.Length)
            {
                Console.WriteLine(products[p].ProductId + ":" + products[p].ProductName + "-" + products[p].ProductCountry);
                p++;
            }


        }

    }

    class Product
    {
        public String ProductName { get; set; }
        public int ProductId { get; set; }
        public String ProductCountry { get; set; }

    }
}
