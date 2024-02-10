namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            bool isFirstArratSelected = true;
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                if(isFirstArratSelected)
                {
                    arr1[i] = numbers[0];
                    arr2[i] = numbers[1];
                }
                else
                {
                    arr1[i] = numbers[1];
                    arr2[i] = numbers[0];
                }
                isFirstArratSelected = ! isFirstArratSelected;
            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}