namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();  

            List<int> rezult = new List<int>();

            int sum = 0;
            
            for(int i = 0; i < numbers.Count/2; i++)
            {
                sum = numbers[i]+numbers[numbers.Count - 1 - i];
                rezult.Add(sum);
                sum = 0;
            }
            if (numbers.Count % 2 != 0)
            {
                rezult.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", rezult));
        }
    }
}