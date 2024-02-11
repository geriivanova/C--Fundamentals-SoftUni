namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number, power));
        }

        static double RaiseToPower(double n, double pow)
        {
            double rezult;
            rezult = Math.Pow(n, pow);
            return rezult;

        }
    }
}