namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            while (word != "end")
            {
                char[] reversedWord = word.Reverse().ToArray();
                Console.WriteLine($"{word} = {string.Join("", reversedWord)}");
                word = Console.ReadLine();
            }
        }
    }
}