using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SortingAlgorthmis
    {
        #region SortQuick
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];

            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void SortQuick(int[] arr, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }
        }
        #endregion

        #region MergeSort
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }

        }
        #endregion

        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

        }

        public static void BubbleSort(int[] arr)
        {
            bool IsSorted;
            for (int i = 0; i < arr.Length; i++)
            {
                IsSorted = true;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int x = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = x;
                        IsSorted = false;
                    }
                }
                if (IsSorted)
                    break;
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int MinIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[MinIndex] > arr[j])
                    {
                        MinIndex = j;
                    }
                }

                if (i != MinIndex)
                {
                    int temp = arr[i];
                    arr[i] = arr[MinIndex];
                    arr[MinIndex] = temp;
                }
            }
        }

        public static void Recursive(int[] arr, int i)
        {
            Console.WriteLine(arr[i]);
            i++;

            if (i < arr.Length)
            {
                Recursive(arr, i);
            }
        }
    }
}
