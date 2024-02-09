namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for(int i=0; i<nums.Length; i++)
            {
                int currentNum = nums[i];
                if(currentNum%2 == 0)
                {
                     sum += currentNum;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}