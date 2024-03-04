namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> arrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> newList = new List<string>();
            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                string[] symbol = arrays[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                newList.AddRange(symbol);
            }
            Console.WriteLine (string.Join(" ", newList));
        }
    }
}