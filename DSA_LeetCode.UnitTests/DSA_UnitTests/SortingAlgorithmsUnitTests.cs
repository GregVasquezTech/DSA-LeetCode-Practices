using DSA_LeetCode.DSA.Implementations;

namespace DSA_LeetCode.UnitTests.DSA_UnitTests
{
    public class SortingAlgorithmsUnitTests
    {
        SortingAlgorithms sortingAlgorithms = new();

        [Fact]
        public void ShouldSortArray_Using_InsertionSortingAlgorithm()
        {
            // Arrange
            int[] testArr = CreateArray();
            int[] expectingArr = SortedArray();

            // Act 
            sortingAlgorithms.InsertionSortingAlgorithm(testArr);

            // Assert
            Assert.Equal(expectingArr, testArr);
        }

        [Fact]
        public void ShouldSortArray_Using_SelectionSortingAlgorithm()
        {
            // Arrange
            int[] testArr = CreateArray();
            int[] expectingArr = SortedArray();

            // Act
            sortingAlgorithms.SelectionSortingAlgorithm(testArr);

            // Assert
            Assert.Equal(expectingArr, testArr);
        }

        [Fact]
        public void ShouldSortArray_Using_BubbleSortingAlgorithm()
        {
            // Arrange
            int[] testArr = CreateArray();
            int[] expectingArr = SortedArray();

            // Act 
            sortingAlgorithms.BubbleSortingAlgorithm(testArr);

            // Assert
            Assert.Equal(expectingArr, testArr);
        }

        [Fact]
        public void ShouldSortArray_Using_MergeSortingAlgorithm()
        {
            // Arrange
            int[] testArr = CreateArray();
            int[] expectingArr = SortedArray();

            // Act 
            sortingAlgorithms.MergeSortingAlgorithm(testArr);

            // Assert
            Assert.Equal(expectingArr, testArr);
        }
        [Fact]
        public void ShouldSortArray_Using_ShellSortAlgorithm()
        {
            // Arrange
            int[] testArr = CreateArray();
            int[] expectingArr = SortedArray();

            // Act
            sortingAlgorithms.ShellSortingAlgorithm(testArr);

            // Assert
            Console.WriteLine(expectingArr);
            Assert.Equal(expectingArr, testArr);
        }

        [Fact]
        public void ShouldSortArray_Using_QuickSortAlgorithm()
        {
            // Arrange
            int[] testArr = CreateArray();
            int[] expectingArr = SortedArray();

            // Act
            sortingAlgorithms.QuickSortingAlgorithm(testArr, 0, testArr.Length - 1);

            // Assert
            Assert.Equal(expectingArr, testArr);
        }
        [Fact]
        public void ShouldSortArray_Using_HeapSortAlgorithm()
        {
            // Arrange
            int[] testArr = CreateArray();
            int[] expectingArr = SortedArray();

            // Act
            sortingAlgorithms.HeapSortingAlgorithm(testArr);

            // Assert
            Assert.Equal(expectingArr, testArr);
        }


       // Helper Functions

        private int[] CreateArray()
        {
            return new int[] { 1, -42, 2, -11, 0, 54, 45, 98 };
        }
        private int[] SortedArray()
        {
            int[] testArr = CreateArray();
            Array.Sort(testArr);
            return testArr;
        }
    }
}
