using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int >numberAndPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers = Explode(numbers, numberAndPower);

            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        private static List<int> Explode(List<int> list, List<int> bomb)
        {
            int number = bomb[0];
            int power = bomb[1];

            while (list.Contains(number))
            {
                int index = list.IndexOf(number);

                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(list.Count - 1, index + power);

                int range = rightIndex - leftIndex + 1;
                list.RemoveRange(leftIndex, range);
            }

            return list;
        }
    }
}