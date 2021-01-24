using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string, string> users = new MyDict<int, string, string> { };
     
            users.Add(1, "Elif", "Güven");
            users.Add(2, "Deniz", "Çizgi");
            users.Add(3, "Emir", "Korkmaz");
            Console.WriteLine("Sistemde " + users.Length + " kullanıcı vardır.");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users.Ids[i] + " " + users.Names[i] + " " + users.SurNames[i]);
            }

            Console.WriteLine("------Sistemdeki kullanıcıların ID'leri------");
            foreach (var id in users.Ids)
            {
                Console.WriteLine(id);
            }

            Console.WriteLine("------Sistemdeki kullanıcıların isimleri------ ");
            foreach (var name in users.Names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------Sistemdeki kullanıcıların soyisimleri------");
            foreach (var surName in users.SurNames)
            {
                Console.WriteLine(surName);
            }

        }
    }
}
