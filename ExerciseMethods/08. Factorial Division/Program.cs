using System.Numerics;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());   

            double firstFactoriel = CalculateFactoriel(firstNumber);
            double secondFactoriel=CalculateFactoriel(secondNumber);
            double rezult = firstFactoriel / secondFactoriel;
            Console.WriteLine($"{rezult:F2}");

        }
        static double CalculateFactoriel(double number)
        {
            double factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel*= i;
            }
            return factoriel;
        }
    }
}