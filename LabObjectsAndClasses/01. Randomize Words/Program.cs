namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();

            for(int i = 0; i < words.Length; i++)
            {
                int pos = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[pos];
                words[pos] = temp;
            }
            Console.WriteLine(string.Join("\n", words)); 
        }
    }
}