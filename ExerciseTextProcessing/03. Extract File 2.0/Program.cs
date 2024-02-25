namespace _03._Extract_File_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            Console.WriteLine($"File name: {Path.GetFileNameWithoutExtension(filePath)}");
            Console.WriteLine($"File extension: {Path.GetExtension(filePath).Replace(".","")}");
        }
    }
}