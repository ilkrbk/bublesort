using System;
using System.Collections.Generic;

namespace BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() {4, 28, 21, 85, 35, 30, 1, 2, 5, 3, 67};
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int j = 0; j < array.Count - i - 1; j++)
                {
                    // > по возростанию
                    // < по убыванию
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}