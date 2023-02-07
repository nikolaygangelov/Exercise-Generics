using System;

namespace genericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int numberOfElements = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfElements; i++)
            {
                double element = double.Parse(Console.ReadLine());
                box.Add(element);
            }
            double compairedElement = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Compare(compairedElement));
        }
    }
}
