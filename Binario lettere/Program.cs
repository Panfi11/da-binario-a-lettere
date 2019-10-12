using System;

namespace Binario_lettere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un nome");
            string s;
            Console.WriteLine(" Enter your sentence: ");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                Console.WriteLine((int)c);
            }
            Console.ReadLine();

        }
    }
 }
