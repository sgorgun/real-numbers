using System.Globalization;

namespace Literals.Tests
{
    [TestFixture]
    public class StringsTests
    {
        [Test]
        public void ReturnString71_ReturnsString()
        {
            // Act
            string result = Strings.ReturnString71();

            // Assert
            Assert.AreEqual("Hello, world!", result);
        }

        [Test]
        public void ReturnString72_ReturnsString()
        {
            // Act
            string result = Strings.ReturnString72();

            // Assert
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", result);
        }

        [Test]
        public void ReturnString73_ReturnsString()
        {
            // Assert
            const ulong value = 4_956_185_095_298_947_214uL;

            // Act
            string result = Strings.ReturnString73();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "{0:D}uL", value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReturnString74_ReturnsString()
        {
            // Assert
            const decimal value = 840_452_834.1094m;

            // Act
            string result = Strings.ReturnString74();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "{0:f4}m", value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReturnString75_ReturnsString()
        {
            // Assert
            const ulong value = 187723572702975L;

            // Act
            string result = Strings.ReturnString75();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "0x{0:X}", value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReturnString76_ReturnsString()
        {
            // Assert
            const ulong value = 81985529216486895L;

            // Act
            string result = Strings.ReturnString76();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "0x{0:X}", value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReturnString77_ReturnsString()
        {
            // Assert
            const ulong value = 12379809047621975535L;

            // Act
            string result = Strings.ReturnString77();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "0x{0:X}", value);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReturnString78_ReturnsString()
        {
            // Arrange
            const long value = 9223090566172966912L;

            // Act
            string result = Strings.ReturnString78();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "0b{0}", Convert.ToString(value, 2));
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReturnString79_ReturnsString()
        {
            // Arrange
            const long value = 6148914691236517205L;

            // Act
            string result = Strings.ReturnString79();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "0b{0}", Convert.ToString((long)value, 2));
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReturnString710_ReturnsString()
        {
            // Arrange
            const long value = 1148435428713435120L;

            // Act
            string result = Strings.ReturnString710();

            // Assert
            string expectedResult = string.Format(CultureInfo.InvariantCulture, "0b{0}", Convert.ToString((long)value, 2));
            Assert.AreEqual(expectedResult, result);
        }
    }
}
