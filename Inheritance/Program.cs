using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Employee person = new Employee() { Id = 2, Adi = "Deniz", Soyadi = "Güven", EmployeeNumber = "1234560" };

            customer.Id = 1;
            customer.Adi = "Elif";
            customer.Soyadi = "Güven";
            customer.CreditCardNumber = "1234567890";


            Person person1 = new Employee();
            ((Employee)person1).EmployeeNumber = "147852";

            Console.WriteLine("Çalışan numarası: "+ ((Employee)person1).EmployeeNumber);

       
        }
    }
}
