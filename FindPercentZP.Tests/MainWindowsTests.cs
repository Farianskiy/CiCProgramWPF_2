using FindPercentLib;

namespace FindPercentZP.Tests
{
    public class MainWindowsTests
    {
        [Fact]
        public void TestWithFirstInput()
        {
            // Arrange
            ZadanueTwo zadahaTwo = new ZadanueTwo();
            string expected = "10";
            string zp = "600 100 500 1000";

            // Act
            string result = zadahaTwo.FindPercentZP(zp);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWithSecondInput()
        {
            // Arrange
            ZadanueTwo zadahaTwo = new ZadanueTwo();
            string expected = "100";
            string zp = "100 100";

            // Act
            string result = zadahaTwo.FindPercentZP(zp);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWithThirdInput()
        {
            // Arrange
            ZadanueTwo zadahaTwo = new ZadanueTwo();
            string expected = "33";
            string zp = "100 200 300";

            // Act
            string result = zadahaTwo.FindPercentZP(zp);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWithFourInput()
        {
            // Arrange
            ZadanueTwo zadahaTwo = new ZadanueTwo();
            string expected = "0";
            string zp = "400 300 200 100 1";

            // Act
            string result = zadahaTwo.FindPercentZP(zp);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWithFiveInput()
        {
            // Arrange
            ZadanueTwo zadahaTwo = new ZadanueTwo();
            string expected = "-";
            string zp = "-";

            // Act
            string result = zadahaTwo.FindPercentZP(zp);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}