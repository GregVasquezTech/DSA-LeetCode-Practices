using DSA_LeetCode.DSA.Interfaces;


namespace DSA_LeetCode.DSA.Implementations
{
    public class SortingAlgorithms: ISortingAlgorithms
    {
        public SortingAlgorithms() { }

        public void InsertionSortingAlgorithm(int[] a)
        {
            if (a.Length == 0 || a.Length == 1)
            {
                PrintStatement();
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    int j = i;
                    while (j > 0 && a[j] < a[j -1]) 
                    {
                        (a[j], a[j - 1]) = (a[j - 1], a[j]);
                        j--;
                    }
                }
            }
        }
        public void SelectionSortingAlgorithm(int[] a)
        {
            if (a.Length < 2)
            {
                PrintStatement();
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    int swapValue;
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] < a[i])
                        {
                            swapValue = a[i];
                            a[i] = a[j];
                            a[j] = swapValue;
                        }
                    }
                }
            }
        }
        public void BubbleSortingAlgorithm(int[] a)
        {
            if (a.Length < 2)
            {
                PrintStatement();
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    bool isAnyChanges = false; 
                    for (int j = 0; j < a.Length - 1; j++)
                    {
                        if (a[j + 1] < a[j])
                        {
                            (a[j], a[j + 1]) = (a[j + 1], a[j]);
                            isAnyChanges = true;
                        }
                    }
                    if (!isAnyChanges)
                    {
                        break;
                    }
                }
            }
        }
        public void MergeSortingAlgorithm(int[] a)
        {
            if (a.Length < 2)
            {
                PrintStatement();
            }
            else
            {
                int m = a.Length / 2;
                int i = 0, j = 0, k = 0;

                int[] left = GetSubarray(a, 0, m);
                int[] right = GetSubarray(a, m, a.Length - 1);

                MergeSortingAlgorithm(left);
                MergeSortingAlgorithm(right);

                while (i < left.Length && j < right.Length)
                {
                    if (left[i] < right[j])
                    {
                        a[k] = left[i++];
                    }else
                    {
                        a[k] = right[j++];
                    }
                    k++;
                }
                while (i < left.Length)
                {
                    a[k++] = left[i++];
                }
                while (j < right.Length)
                {
                    a[k++] = right[j++];
                }
            }
        }


        // Helper Functions
        private void PrintStatement()
        {
            Console.WriteLine("Process is not necessary");
        }
        private int[] GetSubarray(int[] a, int startIndex, int endIndex)
        {
            int[] result = new int[endIndex - startIndex + 1];
            Array.Copy(a, startIndex, result, 0, result.Length);
            return result;
        }
    }
}
