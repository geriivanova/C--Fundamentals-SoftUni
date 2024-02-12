namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            CharactesInRange(a, b);
        }
        static void CharactesInRange(char a, char b)
        {
            char newChar = a;
            if(a > b)
            {
                a = b;
                b = newChar;
            }
            for(int i=a+1; i<b; i++) 
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
    }
}