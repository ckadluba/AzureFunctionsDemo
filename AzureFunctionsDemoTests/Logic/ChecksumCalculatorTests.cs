using AzureFunctionsDemo.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureFunctionsDemoTests.Logic
{
    [TestClass]
    public class ChecksumCalculatorTests
    {
        [TestMethod]
        public void ChecksumCalculator_When_CalculateMultiplicationChecksum_Called_With_Small_Integer_It_Returns_Checksum()
        {
            var sut = new ChecksumCalculator();

            var faculty = sut.CalculateMultiplicationChecksum(1234);

            Assert.AreEqual(24, faculty);
        }

        [TestMethod]
        public void ChecksumCalculator_When_CalculateMultiplicationChecksum_Called_With_Large_Integer_It_Returns_Checksum()
        {
            var sut = new ChecksumCalculator();

            var faculty = sut.CalculateMultiplicationChecksum(786743259);

            Assert.AreEqual(2540160, faculty);
        }

        [TestMethod]
        public void ChecksumCalculator_When_CalculateMultiplicationChecksum_Called_With_Zero_It_Returns_Zero()
        {
            var sut = new ChecksumCalculator();

            var faculty = sut.CalculateMultiplicationChecksum(0);

            Assert.AreEqual(0, faculty);
        }

        [TestMethod]
        public void ChecksumCalculator_When_CalculateAdditionChecksum_Called_With_Small_Integer_It_Returns_Checksum()
        {
            var sut = new ChecksumCalculator();

            var faculty = sut.CalculateAdditionChecksum(1234);

            Assert.AreEqual(10, faculty);
        }

        [TestMethod]
        public void ChecksumCalculator_When_CalculateAdditionChecksum_Called_With_Large_Integer_It_Returns_Checksum()
        {
            var sut = new ChecksumCalculator();

            var faculty = sut.CalculateAdditionChecksum(786743259);

            Assert.AreEqual(51, faculty);
        }

        [TestMethod]
        public void ChecksumCalculator_When_CalculateAdditionChecksum_Called_With_Zero_It_Returns_Zero()
        {
            var sut = new ChecksumCalculator();

            var faculty = sut.CalculateAdditionChecksum(0);

            Assert.AreEqual(0, faculty);
        }
    }
}
