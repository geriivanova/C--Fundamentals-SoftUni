using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder rezult = new StringBuilder();

            foreach (string word in words)
            {
                int count = word.Length;

                for(int i = 0; i < count; i++) 
                { 
                    rezult.Append(word);
                }
            }
            Console.WriteLine(rezult);
        }
    }
}