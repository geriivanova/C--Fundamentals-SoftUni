namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            while (firstHand.Count != 0 && secondHand.Count != 0)
            {
                if (firstHand.First() == secondHand.First())
                {
                    firstHand.Remove(firstHand.First());
                    secondHand.Remove(secondHand.First());
                }
                else if (firstHand.First() > secondHand.First())
                {
                    int first = firstHand.First();
                    int second = secondHand.First();
                    firstHand.Remove(first);
                    secondHand.Remove(second);
                    firstHand.Add(first);
                    firstHand.Add(second);
                }
                else if (firstHand.First() < secondHand.First())
                {
                    int first = firstHand.First();
                    int second = secondHand.First();
                    firstHand.Remove(first);
                    secondHand.Remove(second);
                    secondHand.Add(second);
                    secondHand.Add(first);
                }
            }   

            if(firstHand.Count == 0)
            {
                foreach (int second in secondHand)
                {
                    sum += second;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else if(secondHand.Count == 0)
            {
                foreach (int first in firstHand)
                {
                    sum += first;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}