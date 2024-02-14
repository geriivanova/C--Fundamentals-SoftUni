namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while((command=Console.ReadLine())!="end")
            {
                string[] arguments = command.Split();
                if (arguments[0]=="Add")
                {
                    train.Add(int.Parse(arguments[1]));
                }
                else
                {
                    int passengers = int.Parse(arguments[0]);
                    for(int i = 0;i < train.Count; i++)
                    {
                        if ((train[i] + passengers)<=maxCapacity)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }       
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}