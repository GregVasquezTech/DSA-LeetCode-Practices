using System;
using System.Runtime.CompilerServices;

namespace DSA_LeetCode
{
    public class Program
    {


        static void Main(string[] args)
        {
            MainTest();
        }
        private static void MainTest()
        {
            // Assert
            int[] testArr = SetupArray();
            int[] expectedResult = ExpectedResult();

            // Act
            HeapSort(testArr);

            // Assert
            IterateArrays(testArr, expectedResult);

            Console.WriteLine($"Are the arrays equal? {CompareArrays(testArr, expectedResult)}");
        }

        private static int[] SetupArray()
        {
            return new int[] { 5, 1 - 4, 10, -26, 2, -97, 54, 21, -38, 99 };
        }

        private static int[] ExpectedResult()
        {
            int[] expectedArr = SetupArray();
            Array.Sort(expectedArr);
            return expectedArr;
        }

        private static void IterateArrays(int[] testArr, int[] expectedArr)
        {
            for (int i = 0; i < testArr.Length; i++)
            {
                Console.WriteLine($"Test array: {testArr[i]}                              Expected array: {expectedArr[i]}");
            }
            Console.WriteLine("");
        }

        private static bool CompareArrays(int[] testArr, int[] expectedArr)
        {
            bool isEqual = false;
            if (testArr.Length != expectedArr.Length)
            {
                return isEqual;
            }

            for (int i = 0; i < testArr.Length; i++)
            {
                if (testArr[i] != expectedArr[i])
                {
                    isEqual = false; 
                    break;
                }
                isEqual = true;
            }
            return isEqual;
        }

        private static void SelectionSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
            }
        }

        private static void InsertionSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && arr[j] < arr[j - 1])
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            } 
        }

        private static void BubbleSort(int[] arr)
        {
            if (arr.Length < 2) 
            { 
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {

                bool isAnyChanges = false;
                for (int j = 0; j < arr.Length - 1; j++) 
                {
                    if (arr[j + 1] < arr[j])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        isAnyChanges = true;
                    }
                }
                if (!isAnyChanges)
                {
                    break;
                }
            }
        }

        private static void MergeSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            int middle = arr.Length / 2;
            int j = 0;

            int[] leftArr = new int[middle];
            int[] rightArr = new int[arr.Length - middle];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    leftArr[i] = arr[i];
                }
                else
                {
                    rightArr[j++] = arr[i];
                }
            }

            MergeSort(leftArr);
            MergeSort(rightArr);
            MergeArrays(arr, leftArr, rightArr);
        }

        private static void ShellSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int j = gap; j < arr.Length; j++)
                {
                    for (int i = j - gap; i >= 0 ; i -= gap)
                    {
                        if (arr[i + gap] < arr[i])
                        {
                            (arr[i], arr[i + gap]) = (arr[i + gap], arr[i]);
                        }
                    }
                }
            }
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (arr.Length < 2)
            {
                return;
            }

            if ( end <= start)
            {
                return;
            }

            int pivot = PartitionQuickSort(arr, start, end);
            QuickSort(arr, start, pivot - 1);
            QuickSort(arr, pivot + 1, end);
        }
        private static void HeapSort(int[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, arr.Length, i);
            }
            for (int i = arr.Length - 1; i > 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                Heapify(arr, i, 0);
            }
        }


        // Helper Functions 
        private static void MergeArrays(int[] sortArr, int[] leftArr, int[] rightArr)
        {
            int l = 0, r = 0, s = 0;

            while (l < leftArr.Length && r < rightArr.Length) 
            {
                if (leftArr[l] <= rightArr[r])
                {
                    sortArr[s++] = leftArr[l++];
                }
                else
                {
                    sortArr[s++] = rightArr[r++];
                }
            }
            
            while (l < leftArr.Length)
            {
                sortArr[s++] = leftArr[l++];
            }

            while (r < rightArr.Length)
            {
                sortArr[s++] = rightArr[r++];
            }
        }

        private static int PartitionQuickSort(int[] arr, int start, int end)
        {
            int i = start -1;
            int pivot = arr[end];

            for (int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            i++;
            (arr[i], arr[end]) = (arr[end], arr[i]);

            return i;
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            int max = i;

            max = l < n && arr[l] > arr[max] ? l : max;
            max = r < n && arr[r] > arr[max] ? r : max;

            if (max != i)
            {
                (arr[i], arr[max]) = (arr[max], arr[i]);
                Heapify(arr, n, max);
            }
        }
    }
}