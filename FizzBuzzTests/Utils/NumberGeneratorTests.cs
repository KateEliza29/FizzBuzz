using NUnit.Framework;

namespace FizzBuzzTests.Utils
{
    public class NumberGeneratorTests
    {
        private FizzBuzz.Utils.NumberGenerator _numberGenerator;

        [SetUp]
        public void SetUp()
        {
            _numberGenerator = new FizzBuzz.Utils.NumberGenerator();
        }

        [TestCase(1, 10, 10)]
        [TestCase(10, 15, 6)]
        [TestCase(80, 101, 22)]
        public void GetNumberList_CalledWithValidNumbers_ReturnsArrayOfExpectedLength(int startNumber, int endNumber, int expectedLength)
        {
            var numberList = _numberGenerator.GetNumberList(startNumber, endNumber);
            Assert.That(numberList.Count(), Is.EqualTo(expectedLength));
        }


        [TestCase(-1, 5, 0)]
        [TestCase(-90, 100, 0)]
        public void GetNumberList_CalledWithInvalidNumbers_ReturnsEmptyArray(int startNumber, int endNumber, int expectedLength)
        {
            var numberList = _numberGenerator.GetNumberList(startNumber, endNumber);
            Assert.That(numberList.Count(), Is.EqualTo(expectedLength));
        }
    }
}