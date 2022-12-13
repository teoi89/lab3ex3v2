using System;

namespace lab3ex3v2
{
    class Program
    {
        /* Scrieti o functie care va determina daca un numar este sau nu
         * patrat perfect. Apelati-o si afisati-i rezultatul */
        static void Main(string[] args)
        {
            Console.WriteLine("Add a number");

            int number = int.Parse(Console.ReadLine());

            if (GetSqareNumber(number))
            {
                Console.WriteLine("The number introduced is a perfect sqare");
            }
            else
            {
                Console.WriteLine("The number introduced is not a perfect sqare");
            }
        }
        public static bool GetSqareNumber(int number)
        {
            if (Math.Ceiling(Math.Sqrt(number)) == Math.Floor(Math.Sqrt(number)))
            {
                return true;
            }
            return false;
        }
    }
}
