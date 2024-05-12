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
            int[] testArray = CreateArray();
            int[] expecting = new int[] { -42, -11 , 0, 1, 2, 45, 54, 98 };

            // Act 
            sortingAlgorithms.InsertionSortingAlgorithm(testArray);

            // Assert
            Assert.Equal(expecting, testArray);
        }

        [Fact]
        public void ShouldSortArray_Using_SelectionSortingAlgorithm()
        {
            // Arrange
            int[] testArray = CreateArray();
            int[] expecting = new int[] { -42, -11, 0, 1, 2, 45, 54, 98 };

            // Act
            sortingAlgorithms.SelectionSortingAlgorithm(testArray);

            // Assert
            Assert.Equal(expecting, testArray);
        }

        [Fact]
        public void ShouldSortArray_Using_BubbleSortingAlgorithm()
        {
            // Arrange
            int[] testArray = CreateArray();
            int[] expecting = new int[] { -42, -11, 0, 1, 2, 45, 54, 98 };

            // Act 
            sortingAlgorithms.BubbleSortingAlgorithm(testArray);

            // Assert
            Assert.Equal(expecting, testArray);
        }

        [Fact]
        public void ShouldSortArray_Using_MergeSortingAlgorithm()
        {
            // Arrange
            int[] testArray = CreateArray();
            int[] expecting = new int[] { -42, -11, 0, 1, 2, 45, 54, 98 };

            // Act 
            sortingAlgorithms.MergeSortingAlgorithm(testArray);

            // Assert
            Assert.Equal(expecting, testArray);
        }






       // Helper Functions

        private int[] CreateArray()
        {
            return new int[] { 1, -42, 2, -11, 0, 54, 45, 98 };
        }
    }
}
