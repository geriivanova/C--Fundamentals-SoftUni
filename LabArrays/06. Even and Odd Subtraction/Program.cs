namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumOfEven = 0;
            int sumOfOdd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                if (currentNum % 2 == 0)
                {
                    sumOfEven += currentNum;
                }
                else if(currentNum % 2 != 0)
                {
                    sumOfOdd += currentNum;
                }
            }
            Console.WriteLine(sumOfEven-sumOfOdd);
        }
    }
}