using NUnit.Framework;
using Moq;
using StringSorterApplicatoin.Model.Interfaces;
using StringSorterApplicatoin;

namespace StringSorterApplication.Tests.Controller
{
    [TestFixture]
    public class SortControllerTests
    {
        private Mock<ISortView> _mockView;
        private SortController _controller;

        [SetUp]
        public void Setup()
        {
            _mockView = new Mock<ISortView>();
            _controller = new SortController(_mockView.Object);
        }

        [Test]
        public void SortString_WithValidInputAndBubbleSort_CallsViewMethods()
        {
            // Arrange
            _mockView.Setup(v => v.InputString).Returns("befdac");
            _mockView.Setup(v => v.SelectedStrategy).Returns("BubbleSort");

            // Act
            _controller.SortString();

            // Assert
            _mockView.VerifySet(v => v.OutputString = "abcdef", Times.Once());
        }

        [Test]
        public void SortString_WithValidInputAndQuickSort_CallsViewMethods()
        {
            // Arrange
            _mockView.Setup(v => v.InputString).Returns("befdac");
            _mockView.Setup(v => v.SelectedStrategy).Returns("QuickSort");

            // Act
            _controller.SortString();

            // Assert
            _mockView.VerifySet(v => v.OutputString = "abcdef", Times.Once());
        }

        [Test]
        public void SortString_WithInvalidStrategy_ThrowsException()
        {
            // Arrange
            _mockView.Setup(v => v.InputString).Returns("befdac");
            _mockView.Setup(v => v.SelectedStrategy).Returns("InvalidStrategy");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _controller.SortString());
        }

        [Test]
        public void SortString_WithNullStrategy_ThrowsException()
        {
            // Arrange
            _mockView.Setup(v => v.InputString).Returns("befdac");
            _mockView.Setup(v => v.SelectedStrategy).Returns((string)null);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _controller.SortString());
        }
    }
}