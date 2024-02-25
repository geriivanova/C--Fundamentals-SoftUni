using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder rezult = new StringBuilder();
            rezult.Append(text[0]);

            for(int i = 1; i < text.Length; i++) 
            {
                if (text[i] != text[i-1])
                {
                    rezult.Append(text[i]);
                }
            }
            Console.WriteLine(rezult);
        }
    }
}