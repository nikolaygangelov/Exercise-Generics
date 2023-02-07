using System;
using System.Linq;

namespace genericSwapMethodIntegers
{
    public class StartUp
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

            int[] indexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int indexToswap1 = indexes[0];
            int indexToswap2 = indexes[1];
            box.Swap(indexToswap1, indexToswap2);
            Console.WriteLine(box.ToString());
        }
    }
}
