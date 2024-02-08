namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litersInTank = 0;
            int leftLiters = 255;

            for(int i=1; i<=n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if(liters<=255 && liters<=leftLiters)
                {
                    litersInTank+=liters;
                    leftLiters -= liters;
                }
                else if(liters > leftLiters)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
               
            }
            Console.WriteLine(litersInTank);
        }
    }
}