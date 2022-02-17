using System;

namespace P129HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 76, 13, 65, 34, 92, 15 };
            CustomSort(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static int[] CustomSort(int[] a)
        {
            int b;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    { 
                        b = a[i];
                        a[i] = a[j];
                        a[j] = b;
                    }
                }
            }
            return a;
        }
    }
}
