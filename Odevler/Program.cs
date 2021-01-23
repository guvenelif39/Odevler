using System;

namespace Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product();
            product1.productName = "Masa";
            product1.category = "Ev Eşyası";
            product1.price = 50;

            Product product2 = new Product();
            product2.productName = "Yatak Örtüsü";
            product2.category = "Ev Eşyası";
            product2.price = 120;

            Product[] allProducts = new Product[] { product1, product2 };

            Console.WriteLine("------FOREACH DÖNGÜSÜ--------");
            foreach (Product item in allProducts) // foreach döngüsü
            {
                Console.WriteLine(item.productName + " " + item.category + " " + item.price);
            }
            Console.WriteLine("---------FOR DÖNGÜSÜ-----------");
            for (int i = 0; i < allProducts.Length; i++) // for döngüsü
            {
                Console.WriteLine(allProducts[i].productName + " " + allProducts[i].category + " " + allProducts[i].price);
            }
            Console.WriteLine("---------WHİLE DÖNGÜSÜ---------");
            int j = 0;
            while (j<allProducts.Length)
            {
                Console.WriteLine(allProducts[j].productName + " " + allProducts[j].category + " " + allProducts[j].price);
                j++;
            }
        }
    }
}
