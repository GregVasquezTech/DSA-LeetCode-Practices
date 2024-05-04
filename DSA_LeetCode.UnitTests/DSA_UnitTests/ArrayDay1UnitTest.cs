using DSA_Practices.DSA.Implementations;

namespace DSA_LeetCode.UnitTests.DSA_UnitTests
{
    public class ArrayDay1UnitTest
    {
        public ArrayDay1UnitTest() 
        { 
        }
        Array_Day1 array_Day1 = new Array_Day1(3);

        [Fact]
        public void ShouldCreateAnArray()
        {
            // Arrange
            array_Day1.arr = CreateArray();

            // Act 
            var result = array_Day1.Size();

            // Assert
            Assert.Equal(3, result);
        }
        [Fact]
        public void ShouldNotBeEmpty()
        {
            // Arrange
            array_Day1.arr = CreateArray();

            // Act
            var result = array_Day1.IsEmpty();

            // Assert
            Assert.False(result);
        }
        [Fact]  
        public void ShouldReturnIndexOfAnElement()
        {
            // Arrange
            array_Day1.arr = array_Day1.arr = CreateArray();
                
            // Act
            var result = array_Day1.IndexOf(2);

            // Assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Should_IncreaseArraySize_And_AddNewElement()
        {
            // Arrange
            array_Day1.arr = CreateArray();

            // Act
            int[] result = array_Day1.Add(4);

            // Assert
            Assert.Equal(4, result[3]);
        }
        [Fact]
        public void Should_DecreaseArraySize_And_DeleteAnElement()
        {
            // Arrange
            array_Day1.arr = CreateArray();

            // Act
            array_Day1.RemoveAt(2);

            // Assert
            Assert.Equal(array_Day1.Size(), 2);
        }
        [Fact]
        public void Should_DecreaseArraySize_And_DeleteASpecificElement()
        {
            // Arrange
            array_Day1.arr = CreateArray();

            // Act
            array_Day1.Remove(2);

            // Assert
            Assert.False(array_Day1.Contains(2));
        }


        // Helper Functions
        private int[] CreateArray()
        {
            return new int[] { 1, 2, 1 };
        }
    }
}