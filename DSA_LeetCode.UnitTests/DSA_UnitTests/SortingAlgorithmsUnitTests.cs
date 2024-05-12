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
            int[] expectingArr = new int[] { -42, -11 , 0, 1, 2, 45, 54, 98 };

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
            int[] expectingArr = new int[] { -42, -11, 0, 1, 2, 45, 54, 98 };

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
            int[] expectingArr = new int[] { -42, -11, 0, 1, 2, 45, 54, 98 };

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
            int[] expectingArr = new int[] { -42, -11, 0, 1, 2, 45, 54, 98 };

            // Act 
            sortingAlgorithms.MergeSortingAlgorithm(testArr);

            // Assert
            Assert.Equal(expectingArr, testArr);
        }






       // Helper Functions

        private int[] CreateArray()
        {
            return new int[] { 1, -42, 2, -11, 0, 54, 45, 98 };
        }
    }
}
