using System.Diagnostics.CodeAnalysis;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] wagon= new int[n];
            for(int i = 0; i < n; i++)
            {
                int number=int.Parse(Console.ReadLine());
                sum += number;
                wagon[i] = number;
            }
            Console.WriteLine(string.Join(" ",wagon));
            Console.WriteLine(sum);
        }
    }
}