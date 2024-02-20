namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string firstWord= Console.ReadLine();
                string synonymWord = Console.ReadLine();

                if(words.ContainsKey(firstWord) == false)
                {
                    List<string> newWords = new List<string>();// ! initialization of list !
                    newWords.Add(synonymWord);
                    words.Add(firstWord, newWords); 
                }

                else
                {
                    List<string> currentWord = words[firstWord];
                    currentWord.Add(synonymWord);
                }
            }
            
            foreach(var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", " , word.Value)}");
            }
        }
    }
}