namespace _01._Valid_Usernames
{
    internal class Program
    {
        private static bool IsValid(string username)
        {
            return username.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_');
        }

        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach(string username in usernames)
            {
                if(username.Length < 3 || username.Length > 16)
                {
                    continue;
                }
                if(IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}