using System.Net.Mail;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumNumbers(firstNumber, secondNumber);
            int substract = SubtractNumbers(sum, thirdNumber);

            Console.WriteLine(substract);

        }
        static int SumNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static int SubtractNumbers(int a, int b)
        {
            int rezult = a - b;
            return rezult;
        }
    }
}