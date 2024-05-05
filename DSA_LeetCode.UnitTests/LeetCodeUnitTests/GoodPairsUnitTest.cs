using DSA_LeetCode.LeetCode.Implementations;

namespace DSA_LeetCode.UnitTests.LeetCodeUnitTests
{
    public class GoodPairsUnitTest
    {
        GoodPairs goodPairs = new GoodPairs();

        [Fact]
        public void ShouldReturn_GoodPairs()
        {
            // Arrange 
            goodPairs.arr = [ 1, 2, 3, 1, 1, 3 ];

            // Act 
            int result = goodPairs.NumIdenticalPairs(goodPairs.arr);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
