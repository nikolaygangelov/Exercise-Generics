using System;

namespace genericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int numberOfElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfElements; i++)
            {
                string element = Console.ReadLine();
                box.Add(element);
            }
            string compairedElement = Console.ReadLine();
            Console.WriteLine(box.Compare(compairedElement));

        }
    }
}
