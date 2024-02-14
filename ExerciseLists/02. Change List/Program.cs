namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands;
            while((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();

                if (arguments[0] == "Delete") 
                { 
                    int newNumber= int.Parse(arguments[1]);
                    for(int i=0; i<numbers.Count; i++)
                    {
                        if (numbers[i] == newNumber)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (arguments[0] == "Insert")
                {
                    int element = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);

                    numbers.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}