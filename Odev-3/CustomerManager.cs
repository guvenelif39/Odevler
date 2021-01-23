using System;
using System.Collections.Generic;
using System.Text;

namespace Odev_3
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.customerName + " " + customer.customerSurname + " eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.customerName + " " + customer.customerSurname + " çıkartıldı.");
        }

        public void List(Customer[] List)
        {
            foreach (Customer item in List)
            {
                Console.WriteLine(item.Id + " " + item.customerName + " " + item.customerSurname + " müşteri listenlendi.");
            }
        }
    }
}
