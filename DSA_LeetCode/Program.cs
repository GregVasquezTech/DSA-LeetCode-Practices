using System;

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
            ShellSort(testArr);

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
                }
            }
            return isEqual;
        }
        private static void SelectionSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Out of bounds");
                return;
            }

            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = i + 1;  j < arr.Length; j++)
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
            if (arr.Length == 0)
            {
                Console.WriteLine("Out of bounds");
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
            if (arr.Length == 0)
            {
                Console.WriteLine("Out of bounds");
                return;
            }

            bool isAnyChanges = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;  j < arr.Length -1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        isAnyChanges = true;
                    }
                    else
                    {
                        isAnyChanges = false;
                    }
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

            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    left[i] = arr[i];
                }
                else
                {
                    right[j++] = arr[i];
                }
            }

            MergeSort(left);
            MergeSort(right);
            MergeArray(arr, left, right);
        }
        private static void MergeArray(int[] sortArr, int[] leftArr, int[] rightArr)
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
        private static void ShellSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Out of bounds array");
                return;
            }
            for (int h = arr.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < arr.Length; i++)
                {
                    for (int j = i - h; j >= 0; j -= h)
                    {
                        if (arr[j + h] > arr[j])
                        {
                            break;
                        }
                        else
                        {
                            (arr[j + h], arr[j]) = (arr[j], arr[j + h]);
                        }
                    }
                }
            }
        }
    }
}