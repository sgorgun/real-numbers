#pragma warning disable CA1707

namespace Literals.Tests
{
    [TestFixture]
    public class BoolsTests
    {
        [Test]
        public void ReturnBool61_ReturnsBool()
        {
            // Act
            bool result = Bools.ReturnBool61();

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ReturnBool62_ReturnsBool()
        {
            // Act
            bool result = Bools.ReturnBool62();

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
