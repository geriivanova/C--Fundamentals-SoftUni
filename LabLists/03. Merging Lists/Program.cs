namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> rezult = new List<int>();

            int minCount = Math.Min(firstList.Count, secondList.Count);

            for(int i = 0; i < minCount; i++)
            {
                rezult.Add(firstList[i]);
                rezult.Add(secondList[i]);
            }

            if(minCount==firstList.Count)
            {
                for(int i = minCount; i<secondList.Count; i++)
                {
                    rezult.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = minCount; i < firstList.Count; i++)
                {
                    rezult.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", rezult));
        }
    }
}