using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Programming today is a race between software engineers striving to build bigger " +
                "and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far," +
                "the universe is winning.");
            Console.WriteLine($"What word would you like to search for in the above text?");
            string answer = Console.ReadLine();

            Console.WriteLine($"What word would you like to change it to?");
            string change = Console.ReadLine();

            Console.WriteLine("Sorry, I could not find your word {INSERT THEIR WORD HERE}."); 

        }
    }
}
