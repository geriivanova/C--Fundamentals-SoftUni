namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            switch (command)
            {
                case "+": 
                    Add(firstNumber, secondNumber); 
                    break;
                case "*": 
                    Multiply(firstNumber, secondNumber); 
                    break;
                case "-": 
                    Subtract(firstNumber, secondNumber); 
                    break;
                case "/": 
                    Divide(firstNumber, secondNumber); 
                    break;
            }
        }
            static void Add(int first, int second)
            {
                int result = first + second;
                Console.WriteLine(result);
            }
            static void Multiply(int first, int second)
            {
                int result = first * second;
                Console.WriteLine(result);
            }
            static void Subtract(int first, int second)
            {
                int result = first - second;
                Console.WriteLine(result);
            }
            static void Divide(int first, int second)
            {
                int result = first / second;
                Console.WriteLine(result);
            }
        
    }
}