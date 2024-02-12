namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int rezult = Vowels(word);

            Console.WriteLine(rezult);

        }

        public static int Vowels(string word)
        {
            int count = 0;

            word = word.ToLower();

            foreach (var symbol in word)
            {
                if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'u' || symbol == 'i')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
