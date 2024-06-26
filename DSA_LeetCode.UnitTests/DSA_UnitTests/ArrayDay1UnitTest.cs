﻿using DSA_Practices.DSA.Implementations;

namespace DSA_LeetCode.UnitTests.DSA_UnitTests
{
    public class ArrayDay1UnitTest
    {
        private readonly Array_Day1 _array_Day1;

        [Fact]
        public void ShouldCreateAnArray()
        {
            // Arrange
            _array_Day1.arr = CreateArray();

            // Act 
            var result = _array_Day1.Size();

            // Assert
            Assert.Equal(3, result);
        }
        [Fact]
        public void ShouldNotBeEmpty()
        {
            // Arrange
            _array_Day1.arr = CreateArray();

            // Act
            var result = _array_Day1.IsEmpty();

            // Assert
            Assert.False(result);
        }
        [Fact]  
        public void ShouldReturnIndexOfAnElement()
        {
            // Arrange
            _array_Day1.arr = CreateArray();

            // Act
            var result = _array_Day1.IndexOf(2);

            // Assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Should_IncreaseArraySize_And_AddNewElement()
        {
            // Arrange
            _array_Day1.arr = CreateArray();

            // Act
            _array_Day1.Add(4);

            // Assert
            Assert.Equal(4, _array_Day1.arr[3]);
        }
        [Fact]
        public void Should_DecreaseArraySize_And_DeleteAnElement()
        {
            // Arrange
            _array_Day1.arr = CreateArray();

            // Act
            _array_Day1.RemoveAt(2);

            // Assert
            Assert.Equal(_array_Day1.Size(), 2);
        }
        [Fact]
        public void Should_DecreaseArraySize_And_DeleteASpecificElement()
        {
            // Arrange
            _array_Day1.arr = CreateArray();

            // Act
            _array_Day1.Remove(2);

            // Assert
            Assert.False(_array_Day1.Contains(2));
        }


        // Helper Functions
        private int[] CreateArray()
        {
            return new int[] { 1, 2, 1 };
        }
    }
}