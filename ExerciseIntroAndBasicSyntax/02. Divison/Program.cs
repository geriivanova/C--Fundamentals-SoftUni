using System.Threading.Channels;

namespace _2._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxdev=0;
            if(number%2==0)
            {
                maxdev = 2;
            }
            if(number%3==0)
            {
                maxdev = 3;
            }
            if (number%6==0)
            {
                maxdev = 6;
            }
            if( number%7==0)
            {
                maxdev = 7;
            }
            if( number%10==0)
            { 
                maxdev = 10;
            }
            if(maxdev==0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {maxdev}");
            }
        }
    }
}