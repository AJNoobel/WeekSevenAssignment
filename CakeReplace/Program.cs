using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = "The c4ke i3 4 l1e";
            Console.WriteLine($"{cake}.", cake);
            cake = cake.Replace("4", "a").Replace("3", "s").Replace("1", "i");
            Console.WriteLine($"{cake}", cake);
        }
    }
}
