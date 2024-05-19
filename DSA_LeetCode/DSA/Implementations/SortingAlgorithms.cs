using DSA_LeetCode.DSA.Interfaces;


namespace DSA_LeetCode.DSA.Implementations
{
    public class SortingAlgorithms: ISortingAlgorithms
    {
        public SortingAlgorithms() { }

        public void InsertionSortingAlgorithm(int[] arr)
        {
            if (arr.Length < 2)
            {
                PrintStatement();
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
        public void SelectionSortingAlgorithm(int[] arr)
        {
            if (arr.Length < 2)
            {
                PrintStatement();
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        (arr[j], arr[i]) = (arr[i], arr[j]);
                    }
                }
            }
        }
        public void BubbleSortingAlgorithm(int[] arr)
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
        public void MergeSortingAlgorithm(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            int middleLength = arr.Length / 2;

            int[] leftArr = new int[middleLength];
            int[] rightArr = new int[arr.Length - middleLength];

            int i = 0; // For left array
            int j = 0; // For right array

            for (; i < arr.Length; i++)
            {
                if ( i < middleLength )
                {
                    leftArr[i] = arr[i];
                }
                else
                {
                    rightArr[j++] = arr[i];
                }
            }
            MergeSortingAlgorithm(leftArr);
            MergeSortingAlgorithm(rightArr);
            MergeArray(arr, leftArr, rightArr);
        }
        public void ShellSortingAlgorithm(int[] arr)
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
                    for (int startIndex = gapIndex - gap; startIndex >= 0; startIndex-=gap)
                    {
                        if (arr[startIndex + gap] > arr[startIndex])
                        {
                            break;
                        }
                        else
                        {
                            (arr[startIndex + gap], arr[startIndex]) = (arr[startIndex], arr[startIndex + gap]);
                        }
                    }
                }
            }
        }
        public void QuickSortingAlgorithm(int[] arr, int start, int end)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Out of bounds");
                return;
            }

            if (end <= start)
            {
                return;
            }

            int pivot = PartitionQuickSortArray(arr, start, end);

            QuickSortingAlgorithm(arr, start, pivot - 1);
            QuickSortingAlgorithm(arr, pivot + 1, end);
        }


        // Helper Functions
        private void PrintStatement()
        {
            Console.WriteLine("Process is not necessary");
        }

        private void MergeArray(int[] sortedArr, int[] leftArr, int[] rightArr)
        {
            // Indices
            int s = 0, l = 0, r = 0; 

            while (l < leftArr.Length && r < rightArr.Length)
            {
                if (leftArr[l] < rightArr[r])
                {
                    sortedArr[s++] = leftArr[l++];
                }
                else
                {
                     sortedArr[s++] = rightArr[r++];
                }
            }
            while (l < leftArr.Length)
            {
                sortedArr[s++] = leftArr[l++];
            }
            while (r < rightArr.Length)
            {
                sortedArr[s++] = rightArr[r++];
            }
        }

        private int PartitionQuickSortArray(int[] a, int start, int end)
        {
            int pivot = a[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (a[j] < pivot)
                {
                    i++;
                    (a[i], a[j]) = (a[j], a[i]);
                }
            }

            i++;
            (a[i], a[end]) = (a[end], a[i]);

            return i;
        }
    }
}
