namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            int number1=int.Parse(Console.ReadLine());
            int number2=int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(number1, number2);
            }
            else if(command == "multiply")
            {
                Multiply(number1, number2);
            }
            else if(command == "subtract")
            {
                Substract(number1, number2);
            }
            else if( command == "divide")
            {
                Divide(number1, number2);
            }

        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}