using NUnit.Framework;
using StringSorterApplication.Model;
using StringSorterApplicatoin.Model.Implementations;
using StringSorterApplicatoin.Model.Interfaces;


namespace StringSorterApplication.Tests.Model
{
    internal class SortTests
    {
        private Sort _sort;

        [SetUp]
        public void Setup()
        {
            _sort = new Sort();
        }

        private string GetExpectedSortedString() => "abcdef";

        [Test]
        public void SortString_WithBubbleSort_SortsCorrectly()
        {
            // Arrange
            ISortStrategy bubbleSort = new BubbleSort();
            _sort.SetStrategy(bubbleSort);
            string input = "befdac";

            // Act
            string result = _sort.SortString(input);

            // Assert
            Assert.That(result, Is.EqualTo(GetExpectedSortedString()));
        }

        [Test]
        public void SortString_WithQuickSort_SortsCorrectly()
        {
            // Arrange
            ISortStrategy quickSort = new QuickSort();
            _sort.SetStrategy(quickSort);
            string input = "befdac";

            // Act
            string result = _sort.SortString(input);

            // Assert
            Assert.That(result, Is.EqualTo("abcdef")); 
        }

        [Test]
        public void SortString_WithAlreadySortedInput_ReturnsSameString()
        {
            // Arrange
            string input = "abcdef";
            ISortStrategy bubbleSort = new BubbleSort(); 
            _sort.SetStrategy(bubbleSort);

            // Act
            string result = _sort.SortString(input);

            // Assert
            Assert.That(result, Is.EqualTo(input)); 
        }

        [Test]
        public void SortString_WithNoStrategy_ThrowsException()
        {
            // Arrange
            string input = "befdac";

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _sort.SortString(input));
        }
    }
}