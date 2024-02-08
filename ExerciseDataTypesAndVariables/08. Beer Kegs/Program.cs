namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            double volume = 0;
            double maxVolume = 0;
            string typeOfKeg = string.Empty;

            for(int i=1 ; i<=n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * radius * radius * height;
                
                if(volume > maxVolume)
                {
                    maxVolume = volume;
                    typeOfKeg = model;
                }
            }
            Console.WriteLine(typeOfKeg);
        }
    }
}