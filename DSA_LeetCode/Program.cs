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
            MergeSort(testArr);

            // Assert
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
        private static bool CompareArrays(int[] arr, int[] expectedArr)
        {
            bool isTheSame = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == expectedArr[i])
                {
                    isTheSame = true;
                }
            }
            return isTheSame;
        }
        private static void InsertionSort(int[] arr)
        {
            if (arr.Length < 2) { return; }

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
        private static void SelectionSort(int[] arr)
        {
            if (arr.Length < 2) { return; }

            for (int i = 0; i < arr.Length;i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
            }
        }
        private static void BubbleSort(int[] arr)
        {
            if (arr.Length < 2) { return; }

            for (int i = 0; i < arr.Length; i++)
            {
                bool isAnyChanges = false;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        isAnyChanges = true;
                    }
                }
                if (!isAnyChanges) { break; }
            }
        }
        private static void MergeSort(int[] arr)
        {
            if (arr.Length < 2) { return; }

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
        private static void MergeArray(int[] sortArr, int[] leftArr, int[] rightArr)
        {
            // indices 
            int l = 0, r = 0, s = 0;

            while ( l < leftArr.Length && r < rightArr.Length)
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
    }
}