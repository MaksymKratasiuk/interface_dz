using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_dz
{
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    class Arr : IOutput2
    {
        private int[] data;

        public Arr(int size)
        {
            data = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                data[i] = rand.Next(1, 100);
            }
        }

        public void Show()
        {
            foreach (int item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int item in data)
            {
                sum += item;
            }
            return sum;
        }

        public double Avg()
        {
            return (double)Sum() / data.Length;
        }

        public void ShowEven()
        {
            Console.Write("Even numbers: ");
            foreach (int item in data)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Odd numbers: ");
            foreach (int item in data)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }

    internal class Task2
    {

        public static void task2()
        {
            Arr arr = new Arr(10);
            arr.Show();
            Console.WriteLine("Sum: " + arr.Sum());
            Console.WriteLine("Avg: " + arr.Avg());
            arr.ShowEven();
            arr.ShowOdd();
        }
    }
}
