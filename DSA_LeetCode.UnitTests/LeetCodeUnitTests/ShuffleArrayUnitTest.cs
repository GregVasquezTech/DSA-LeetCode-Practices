using DSA_LeetCode.LeetCode.Implementations;

namespace DSA_LeetCode.UnitTests.LeetCodeUnitTests
{
    public class ShuffleArrayUnitTest: ShuffleArray
    {
        ShuffleArray shuffleArray = new ShuffleArray();

        [Fact]
        public void ShouldReturn_ShuffledArray()
        {
            // Arrange
            int[] testArray = new int[] { 2, 5, 1, 3, 4, 7 };
            int testN = 3;

            int[] expectedArray = new int[] { 2, 3, 5, 4, 1, 7 };

            // Act
            int[] results = shuffleArray.Shuffle(testArray, testN);

            // Assert
            Assert.Equal(expectedArray, results);
        }
    }
}
