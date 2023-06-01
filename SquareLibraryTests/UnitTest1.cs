using SquareLibrary.Figures;

namespace SquareLibraryTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Test]
        public void TriangleNegativeSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 3, 4));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, -1, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 2, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }

        [Test]
        public void TriangleNotTriangleTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 4));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 4, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 4, 1));
        }

        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.AreEqual(Math.PI * 10 * 10, circleSquare);
        }

        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.Square;

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        [Test]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }

    }
}