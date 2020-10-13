using System;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {-34,-67,23,-2,567,-943,2345,41};
            Sort.InsertionSort(arr);
            Console.WriteLine(string.Join("|",arr));
            
        }
    }
    class Sort
    {
        public static void SelectionSort<T>(T[] arr) where T:IComparable
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = arr[minIndex];

                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = arr[j];
                    }
                    Swap(i,minIndex,arr);
                }
            }
        }

        public static void InsertionSort<T>(T[] arr) where T:IComparable
        {
            for(int i = 1;i < arr.Length; i++)
            {
                int j = i;
                while(j > 0 && arr[j].CompareTo(arr[j-1]) < 0)
                {
                    Swap(j,j-1,arr);
                    j--;
                }
            }
        }
        private static void Swap<T>(int p,int q,T[] arr)
        {
            T temp = arr[p];
            arr[p] = arr[q];
            arr[q] = temp;
        }
    }

}
