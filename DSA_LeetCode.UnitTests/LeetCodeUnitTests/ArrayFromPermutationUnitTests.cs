using DSA_LeetCode.LeetCode.Implementations;

namespace DSA_LeetCode.UnitTests.LeetCodeUnitTests
{
    public class ArrayFromPermutationUnitTests
    {
        ArrayFromPermutation arrayFromPermutation = new ArrayFromPermutation();

        [Fact]
        public void ShouldReturn_An_ArrayFromPermutation()
        {
            // Arrange
            int[] array = { 0, 2, 1, 5, 3, 4 };
            int[] expectedArray = new int[] { 0, 1, 2, 4, 5, 3 };

            // Act
            int[] results = arrayFromPermutation.BuildArray(array);

            // Assert
            Assert.Equal(expectedArray, results);
        }
    }
}
