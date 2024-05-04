using DSA_Practices.LeetCode.Implementations;
using DSA_Practices.LeetCode.Interfaces;

namespace DSA_LeetCode.UnitTests.LeetCodeUnitTests
{
    public class ConcatenationArrayUnitTests
    {

        private readonly ConcatentationArray _concatenationArray;

        [Fact]
        public void ShouldConcatenateTwoArrays()
        {
            // Arrange
            _concatenationArray.arr = SetupArray();
            int[] expectedResults = { 1, 2, 1, 1, 2, 1 };

            // Act
            int[] results = _concatenationArray.GetConcatenation(_concatenationArray.arr);

            // Assert 
            Assert.Equal(6, results.Length);
            Assert.Equal(results, expectedResults);
        }


        // Helper Functions
        private int[] SetupArray()
        {
            return new int[] { 1, 2, 1 };
        }
    }
}
