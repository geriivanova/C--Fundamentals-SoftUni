namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0; 
            
            foreach (string s in strings)
            {
                char letterBefore = s[0];
                char letterAfter = s[s.Length - 1];
                decimal number = decimal.Parse(s.Substring(1,s.Length - 2));

                decimal position;
                decimal result = 0;

                if(char.IsUpper(letterBefore))
                {
                    position = letterBefore - 'A' + 1;
                    result = number / position;
                }
                else if(char.IsLower(letterBefore))
                {
                    position = letterBefore - 'a' + 1;
                    result = number * position;
                }

                if (char.IsUpper(letterAfter))
                {
                    position = letterAfter - 'A' + 1;
                    result -= position;
                }
                else if (char.IsLower(letterAfter))
                {
                    position = letterAfter - 'a' + 1;
                    result += position;
                }

                totalSum += result;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}