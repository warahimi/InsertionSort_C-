using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 12, 2, 1, 3, 90, -1 };
            InsertionSort(arr);
            foreach (var x in arr) { Console.WriteLine(x); }
        }
        public static void InsertionSort(int[] arr)
        {
            int key = 0;
            int j =0;
            for(int i =1; i <= arr.Length-1; i++) 
            {
                key = arr[i];
                j = i - 1;
                while(j >= 0 && key < arr[j])
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = key;

            }
        }
    }
}