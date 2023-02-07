using System;

namespace genericBoxOfInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < numberOfStrings; i++)
            {
                int item = int.Parse(Console.ReadLine());
                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
