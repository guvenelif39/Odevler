using System;

namespace Odev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 123;
            customer1.customerName = "Elif";
            customer1.customerSurname = "Güven";

            Customer customer2 = new Customer();
            customer2.Id = 234;
            customer2.customerName = "Deniz";
            customer2.customerSurname = "Güven";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

            Console.WriteLine("-----MÜŞTERİ LİSTESİ-----");
            Customer[] listCustomer = new Customer[] { customer1, customer2 };
            customerManager.List(listCustomer);
            
        }
    }
}
