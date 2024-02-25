namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int slashIndex = input.LastIndexOf('\\');
            int dotIndex = input.LastIndexOf('.');

            if(slashIndex != -1 && dotIndex != -1 && dotIndex > slashIndex)
            {
                fileName = input.Substring(slashIndex + 1, dotIndex - slashIndex - 1);
                fileExtension = input.Substring(dotIndex + 1);
            }
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}