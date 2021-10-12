using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("palun sisesta kasutajatunnus");
                string user = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("sisesta kasutaja parool");
                string PIN = Console.ReadLine();
                if (user == "Admin" && PIN == "admin1234")  
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else if (PIN.Length > 4)
                {
                    Console.WriteLine($"vale PIN, {3 - i} katset on jäänud");
                    i = i + 1;

                }
            }
        }
    }
}
