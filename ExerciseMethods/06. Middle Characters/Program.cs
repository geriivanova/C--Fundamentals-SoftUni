namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleCharacters(word);
        }
        
        static void MiddleCharacters(string characters)
        {
            int length = characters.Length;
            if(length % 2 == 0)
            {
                for (int i = 0; i <= length / 2; i++)
                {
                    if (i == length / 2)
                    {
                        Console.WriteLine($"{characters[i - 1]}{ characters[i]}");
                    }
                }
            }
            else if( length % 2 != 0)
            {
                for (int i = 0; i <= length / 2; i++)
                {
                    if (i == length / 2)
                    {
                        Console.WriteLine(characters[i]);
                    }
                }
            }
        }
    }
}