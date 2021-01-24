using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            Console.WriteLine(sehirler.Length); // Array uzunluğu yazdırır.
           

            foreach (var item in sehirler.Items) // Array elemanlarını yazdırır.
            {
                Console.WriteLine(item); 
            }
        }
    }
}
