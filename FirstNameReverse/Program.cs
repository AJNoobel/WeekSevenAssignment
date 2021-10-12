using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("palun sisesta enda eesnimi");
            string firstname = Console.ReadLine();
            if  (firstname.Length > 5)
            {

                for (int i = firstname.Length - 1; i >= 0; i--)
                {

                    Console.WriteLine(firstname[i]);
                }
                

                




            }
            else if (firstname.Length <= 5)
            {
                Console.WriteLine(firstname);

            }
        }
    }
}
