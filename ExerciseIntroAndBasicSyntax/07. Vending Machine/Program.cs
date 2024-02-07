using System.Threading.Channels;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputCoins = Console.ReadLine();
            double sumMoney = 0;
            while(inputCoins!="Start")
            { 
                double money=double.Parse(inputCoins);
                if(money==0.1 || money==0.2 || money==0.5 || money==1 || money==2)
                {
                    sumMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                inputCoins = Console.ReadLine();
            }

            string product=Console.ReadLine();
            
            while(product!="End")
            {
                if(product=="Nuts")
                {
                    if (sumMoney >= 2)
                    {
                        sumMoney -= 2;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if(product=="Water")
                {
                    if(sumMoney >= 0.7)
                    {
                        sumMoney -= 0.7;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if( product=="Crisps")
                {
                    if( sumMoney >=1.5)
                    {
                        sumMoney -= 1.5;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sumMoney >= 0.8)
                    {
                        sumMoney -= 0.8;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (sumMoney >= 1)
                    {
                        sumMoney -= 1;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product=Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumMoney:F2}");
        }
    }
}