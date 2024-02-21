namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;

            for(int i = 0; i < text.Length; i++)
            {
                char c = text[i];   
                if(char.IsDigit(c))
                {
                    digits += c;
                }
                else if(char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    symbols += c;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}