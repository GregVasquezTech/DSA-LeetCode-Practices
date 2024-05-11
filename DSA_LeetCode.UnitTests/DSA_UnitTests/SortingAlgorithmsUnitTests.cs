using DSA_LeetCode.DSA.Implementations;

namespace DSA_LeetCode.UnitTests.DSA_UnitTests
{
    public class SortingAlgorithmsUnitTests
    {
        SortingAlgorithms sortingAlgorithms = new();

        [Fact]
        public void ShouldSortArray_Using_InsertionSortAlgorithm()
        {
            // Arrange
            int[] testArray = CreateArray();
            int[] expected = new int[] { -42, -11 , 0, 1, 2, 45, 54, 98 };

            // Act 
            sortingAlgorithms.InsertionSortingAlgorithm(testArray);

            // Assert
            Assert.Equal(expected, testArray);
        }

        [Fact]
        public void ShouldSortArray_Using_SelectionSortAlgorithm()
        {
            // Arrange
            int[] testArray = CreateArray();
            int[] expected = new int[] { -42, -11, 0, 1, 2, 45, 54, 98 };

            // Act
            sortingAlgorithms.SelectionSortingAlgorithm(testArray);

            // Assert
            Assert.Equal(expected, testArray);
        }







       // Helper Functions

        private int[] CreateArray()
        {
            return new int[] { 1, -42, 2, -11, 0, 54, 45, 98 };
        }
    }
}
