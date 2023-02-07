using System;

namespace genericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int numberOfStrings = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < numberOfStrings; i++)
            {
                string item = Console.ReadLine();
                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
