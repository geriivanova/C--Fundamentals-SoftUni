namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());

            List <string> name = new List<string>();

            for(int i=0; i<guestCount; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string guestName= commands[0];
                if (commands[2]=="going!")
                {
                    if (name.Exists(n => n == guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        name.Add(guestName);
                    }
                }
                else if (commands[2]=="not")
                {
                    if (name.Exists(n => n == guestName))
                    {
                        name.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", name));
        }
    }
}