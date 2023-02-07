using System;
using System.Collections.Generic;
using System.Text;

namespace genericCountMethodDoubles
{
    public class Box<T> where T : IComparable<T> 
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            (items[firstIndex], items[secondIndex]) = (items[secondIndex], items[firstIndex]);
        }

        public int Compare(T compairedElement)
        {
            int count = 0;
            foreach (T item in items)
            {
                if (item.CompareTo(compairedElement) == 1)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
