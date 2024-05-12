using DSA_LeetCode.LeetCode.Implementations;

namespace DSA_LeetCode.UnitTests.LeetCodeUnitTests
{
    public class FindWordsContainingCharacterUnitTests
    {
        FindWordsContainingCharacter findWordsContainingCharacter = new FindWordsContainingCharacter();


        [Fact]
        public void ShouldReturn_ArrayOfIndices()
        {
            // Arrange
            string[] words = Setup();
            char x = 'a';

            IList<int> expectingResult = new List<int> { 0, 2 };

            // Act
            IList<int> result = findWordsContainingCharacter.FindWordsContaining(words, x);

            // Assert
            Assert.Equal(expectingResult, result);
        }




        private string[] Setup()
        {
            return new string[] { "abc", "bcd", "aaaa", "cbc" };
        }

    }
}
