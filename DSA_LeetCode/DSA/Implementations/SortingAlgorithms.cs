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



        // Helper Functions
        public void PrintStatement()
        {
            Console.WriteLine("Process is not necessary");
        }
    }
}
