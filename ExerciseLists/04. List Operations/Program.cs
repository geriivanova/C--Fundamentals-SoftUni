namespace _04._List_Operations
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
            while( (commands=Console.ReadLine()) != "End")
            {
                string[] argument = commands.Split();

                if (argument[0]=="Add")
                {
                    numbers.Add(int.Parse(argument[1]));
                }
                else if (argument[0]=="Insert")
                {
                    int number = int.Parse(argument[1]);
                    int index = int.Parse(argument[2]);
                    numbers.Insert(index, number);
                }
                else if (argument[0]=="Delete")
                {
                    int deleteIndex = int.Parse(argument[1]);
                    numbers.RemoveAt(deleteIndex);
                }
                else if (argument[0]=="Sift")
                {

                }
            }
        }
    }
}