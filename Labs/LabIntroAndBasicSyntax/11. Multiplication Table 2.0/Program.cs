namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int mul=int.Parse(Console.ReadLine());
            if(mul>10)
            {
                Console.WriteLine($"{number} X {mul} = {number * mul}");
            }
            else
            {
                for (int i = mul;i<=10;i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            
        }
    }
}