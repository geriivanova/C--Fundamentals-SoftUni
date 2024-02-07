using System.Diagnostics;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money=double.Parse(Console.ReadLine());
            double countOfStudents=double.Parse(Console.ReadLine());
            double priceForLightsaber=double.Parse(Console.ReadLine());
            double priceForRobe=double.Parse(Console.ReadLine());
            double priceForBelt=double.Parse(Console.ReadLine());

            double moreLightsabres = countOfStudents + (countOfStudents * 0.1);
            double freeBelts=countOfStudents/6;

            double lightsabresPrice = priceForLightsaber * (Math.Ceiling(moreLightsabres));
            
            double robesPrice = priceForRobe * countOfStudents;
            double beltsPrice=priceForBelt * (countOfStudents-Math.Floor(freeBelts));

            double sumPrice = lightsabresPrice + robesPrice + beltsPrice;
        
            if(sumPrice<=money)
            {
                Console.WriteLine($"The money is enough - it would cost {sumPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(money-sumPrice):F2}lv more.");
            }
        }
    }
}