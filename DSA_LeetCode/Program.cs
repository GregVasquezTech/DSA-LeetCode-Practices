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
            QuickSort(testArr, 0, testArr.Length - 1);

            // Assert
            
            IterateArrays(testArr, expectedResult);

            Console.WriteLine("");

            Console.WriteLine($"Are the arrays equal? {CompareArrays(testArr, expectedResult)}");
        }

        private static int[] SetupArray()
        {
            return new int[] { 5, -11, 24, 59, -42, -1, 8, 2, -97, 1, 3, 10, 4 };
        }
        private static int[] ExpectedResult()
        {
            int[] result = SetupArray();
            Array.Sort(result);
            return result;
        }
        private static void IterateArrays(int[] arr, int[] expectedArr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Test Array: {arr[i]}          Expected Array: {expectedArr[i]}");
            }
        }
        private static bool CompareArrays(int[] arr, int[] expectedArr)
        {
            bool isEqual = false;
            if (arr.Length != expectedArr.Length)
            {
                Console.WriteLine("Unable to compare arrays with different array sizes");
                return isEqual;
            }
            if (arr.Length == 0 || expectedArr.Length == 0)
            {
                Console.WriteLine("Empty Array(s)");
                return isEqual;
            }
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == expectedArr[i])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
                if (!isEqual)
                {
                    i = arr.Length - 1;
                }
            }
            return isEqual;
        }
        private static void PrintStatement()
        {
            Console.WriteLine("Array's size is less than 2, sorting is not needed");
        }
        private static void SelectionSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                PrintStatement();
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i +1; j < arr.Length; j++)
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
                PrintStatement();
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
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
                PrintStatement();
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                bool isAnyChanges = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j+1] < arr[j])
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
            MergeArray(arr, leftArr, rightArr);
        }
        private static void ShellSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                PrintStatement();
                return;
            }

            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int gapIndex = gap; gapIndex < arr.Length; gapIndex++)
                {
                    for (int startIndex = gapIndex - gap; startIndex >= 0; startIndex -= gap)
                    {
                        if (arr[startIndex + gap] > arr[startIndex])
                        {
                            break;
                        }
                        else
                        {
                            (arr[startIndex], arr[startIndex + gap]) = (arr[startIndex + gap], arr[startIndex]);
                        }
                    }
                }
            }
        }
        private static void QuickSort(int[] arr, int start, int end)
        {
            if ( arr.Length < 2)
            {
                return;
            }

            if (end <= start)
            {
                return;
            }

            int pivot = PartitionQuickSort(arr, start, end);

            QuickSort(arr, start, pivot - 1);
            QuickSort(arr, pivot + 1, end);
        }








        // Helper Functions
        private static void MergeArray(int[] sortArr, int[] leftArr, int[] rightArr)
        {
            int l = 0, r = 0, s = 0;

            while(l < leftArr.Length && r < rightArr.Length)
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
        private static int PartitionQuickSort(int[] partArr, int start, int end)
        {
            int i = start - 1;
            int pivot = partArr[end];

            for (int j = start; j < end; j++)
            {
                if (partArr[j] < pivot)
                {
                    (partArr[++i], partArr[j]) = (partArr[j], partArr[i]);
                }
            }

            (partArr[++i], partArr[end]) = (partArr[end], partArr[i]);

            return i;
        }
    }
}