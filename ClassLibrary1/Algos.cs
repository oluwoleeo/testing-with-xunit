using System;

namespace AlgosLib
{
    public class Algos
    {
        public static int[] SortArray(params int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }

            return arr;
        }

        public static int SearchArray(int searchElement, params int[] arr)
        {
            int low = 0, high = arr.Length - 1;
            SortArray(arr);

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] < searchElement)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > searchElement)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public static int Fibonacci(int n)
        {
            int[] fibArr = new int[n + 1];
            fibArr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibArr[i] = fibArr[i - 2] + fibArr[i - 1];
            }

            return fibArr[n];
        }
    }
}
