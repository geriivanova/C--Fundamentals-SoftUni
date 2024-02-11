using System.Security.Cryptography.X509Certificates;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, count));
        }

        static string RepeatString(string input, int count)
        {
            string rezult = "";

            for (int i = 0; i < count; i++)
            {
                rezult += input;
            }
            return rezult;
        }
    }
}