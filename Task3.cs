using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_dz
{
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    class Arr2 : ICalc2
    {
        private int[] data;

        public Arr2(int[] data)
        {
            this.data = data;
        }

        public int CountDistinct()
        {
            return data.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return data.Count(x => x == valueToCompare);
        }
    }
    internal class Task3
    {
        public static void task3()
        {
            int[] data = { 1, 2, 3, 2, 4, 5, 1, 3 };
            Arr2 arr = new Arr2(data);

            Console.WriteLine($"Number of distinct values in array: {arr.CountDistinct()}");
            Console.WriteLine($"Number of values equal to 2 in array: {arr.EqualToValue(2)}");
        }
    }
}