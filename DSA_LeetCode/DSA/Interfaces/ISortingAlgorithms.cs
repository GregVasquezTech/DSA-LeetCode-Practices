namespace DSA_LeetCode.DSA.Interfaces
{
    public interface ISortingAlgorithms
    {
        void SelectionSortingAlgorithm(int[] arr);
        void InsertionSortingAlgorithm(int[] arr);
        void BubbleSortingAlgorithm(int[] arr);
        void MergeSortingAlgorithm(int[] arr);
        void ShellSortingAlgorithm(int[] arr);
        void QuickSortingAlgorithm(int[] arr, int start, int end);
    }
}
