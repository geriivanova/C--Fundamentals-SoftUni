﻿namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = Console.ReadLine()[0];
            if(letter >= 'a' && letter <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else if (letter >= 'A' && letter <= 'Z')
            {
                Console.WriteLine("upper-case");
            }

        }
    }
}