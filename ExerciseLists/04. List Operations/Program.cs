using System;
using System.Reflection;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands;
            while( (commands=Console.ReadLine()) != "End")
            {
                string[] argument = commands.Split();

                if (argument[0]=="Add")
                {
                    numbers.Add(int.Parse(argument[1]));
                }
                else if (argument[0]=="Insert")
                {
                    int number = int.Parse(argument[1]);
                    int index = int.Parse(argument[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (argument[0]=="Remove")
                {
                    int removeIndex = int.Parse(argument[1]);
                    if (removeIndex >= numbers.Count || removeIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(removeIndex);
                    }
                }
                else if (argument[0]=="Shift")
                {
                    if (argument[1] == "left")
                    {
                        int count = int.Parse(argument[2]);
                        for(int i = 0; i < count; i++)
                        {
                            int number = numbers.First();
                            numbers.Add((int)number);
                            numbers.Remove(number);
                        }
                    }
                    else if (argument[1] == "right")
                    {
                        int count = int.Parse(argument[2]);
                        for (int i = 0; i < count; i++)
                        {
                            int number = numbers.Last();
                            numbers.Remove(number);
                            numbers.Insert(0, (int)number); 
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}