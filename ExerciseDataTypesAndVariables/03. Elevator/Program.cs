namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople=int.Parse(Console.ReadLine());
            int elevatorCapacity=int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)countOfPeople / elevatorCapacity);
            Console.WriteLine(courses);
        }
    }
}