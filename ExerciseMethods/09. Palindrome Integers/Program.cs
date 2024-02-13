using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            while(number != "END")
            {
                IsPalindrom(number);
                number = Console.ReadLine();
            }
            
        }

        static void IsPalindrom(string number)
        {
            string check = "true";
            for(int i=0; i<number.Length; i++)
            {
                if (number[i] != number[number.Length-1 - i])
                {
                    check = "false";
                    break;
                }
            }
            Console.WriteLine(check);
        }
    }
}