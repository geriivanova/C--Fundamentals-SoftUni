using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder cipherBuilder = new StringBuilder();

            for(int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                cipherBuilder.Append((char)(c + 3));
            }
            Console.WriteLine(cipherBuilder);
        }
    }
}