using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_dz
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public class Array : ICalc
    {
        private int[] data;

        public Array(int[] input)
        {
            data = input;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int num in data)
            {
                if (num < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int num in data)
            {
                if (num > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

    internal class Task1
    {
        public static void task1()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Array myArray = new Array(arr);
            int lessThanThree = myArray.Less(3);
            int greaterThanFour = myArray.Greater(4);
            Console.WriteLine("Less than 3: " + lessThanThree);
            Console.WriteLine("Greater than 4: " + greaterThanFour);
        }
    }
}
