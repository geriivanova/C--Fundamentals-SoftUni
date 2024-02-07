namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int number = int.Parse(Console.ReadLine());
            int myNumber = number;
            int lastDigit;
            int factoriel = 1;
            int sum = 0;
           
           
            while (number!=0)
            {
                lastDigit = number % 10;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                number = number / 10;
                factoriel = 1;
            }
            if (sum == myNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            

            /*while()
            {
                lastDigit = number % 10;
                newNumber = number / 10;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
            }
            */


            /*if(sum==number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            */



            /*lastDigit= number % 10;//ndmira poslednata cifra
            number = number / 10;
                Console.WriteLine(lastDigit);
            Console.WriteLine(number);
            */





            /*for(int i=1;i<=number;i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
            */

        }
    }
}