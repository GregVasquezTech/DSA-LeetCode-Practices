using DSA_LeetCode.LeetCode.Implementations;

namespace DSA_LeetCode.UnitTests.LeetCodeUnitTests
{
    public class StringFinalValueUnitTest: StringFinalValue
    {
        StringFinalValue stringFinalValue = new StringFinalValue();

        [Fact]
        public void ShouldReturn_StringFinalValue()
        {
            // Arrange
            string[] mockOperations = { "--X", "X++", "X++" };

            // Act
            int result = stringFinalValue.FinalValueAfterOperations(mockOperations);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
