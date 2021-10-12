using System;

namespace randomletter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta enda eesnimi");
            string name = Console.ReadLine();
            Console.WriteLine($"tere, {name.ToUpper()[0]}."); 
        }
    }
}
