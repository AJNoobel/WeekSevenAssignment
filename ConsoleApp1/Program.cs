using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta enda eesnimi:");
            string first = Console.ReadLine();
            Console.WriteLine("Palun sisesta enda perekonna nimi:");
            string last = Console.ReadLine();
            Console.WriteLine($"Tere, {first[0]}. {last[0]}.!");

        }
    }
}
