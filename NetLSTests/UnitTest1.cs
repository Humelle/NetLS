using NetLS;

namespace NetLSTests;

public class Tests
{
    [Test]
        public void IsInside_PointInsideSquare_ReturnsTrue()
        {
            var squareUtils = new SquareUtils(0, 0, 5, 5, 2, 3);
            var result = squareUtils.IsInside();
            Assert.IsTrue(result);
        }

        [Test]
        public void IsInside_PointOutsideSquare_ReturnsFalse()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, -1, 2);
            var result = squareUtils.IsInside();
            Assert.IsFalse(result);
        }

        [Test]
        public void Constructor_InvalidSquareCoordinates_ThrowsException()
        {
            Assert.Throws<Exception>(() => new SquareUtils(10, 10, 0, 0, 5, 5));
        }

        [Test]
        public void xMin_SetValidValue_UpdatesValue()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            squareUtils.xMin = 1;
            Assert.That(squareUtils.xMin, Is.EqualTo(1));
        }

        [Test]
        public void xMin_SetInvalidValue_ThrowsException()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            Assert.Throws<Exception>(() => squareUtils.xMin = 11);
        }

        [Test]
        public void yMin_SetValidValue_UpdatesValue()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            squareUtils.yMin = 1;
            Assert.That(squareUtils.yMin, Is.EqualTo(1));
        }

        [Test]
        public void yMin_SetInvalidValue_ThrowsException()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            Assert.Throws<Exception>(() => squareUtils.yMin = 11);
        }

        [Test]
        public void xMax_SetValidValue_UpdatesValue()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            squareUtils.xMax = 9;
            Assert.That(squareUtils.xMax, Is.EqualTo(9));
        }

        [Test]
        public void xMax_SetInvalidValue_ThrowsException()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            Assert.Throws<Exception>(() => squareUtils.xMax = -1);
        }

        [Test]
        public void yMax_SetValidValue_UpdatesValue()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            squareUtils.yMax = 9;
            Assert.That(squareUtils.yMax, Is.EqualTo(9));
        }

        [Test]
        public void yMax_SetInvalidValue_ThrowsException()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            Assert.Throws<Exception>(() => squareUtils.yMax = -1);
        }

        [Test]
        public void ToString_ReturnsCorrectString()
        {
            var squareUtils = new SquareUtils(0, 0, 10, 10, 5, 5);
            var result = squareUtils.ToString();
            Assert.That(result, Is.EqualTo("Square with coordinates 0, 0, 10, 10\nPoint 5, 5 is inside the square: True"));
        }
}