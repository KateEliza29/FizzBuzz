using NUnit.Framework;

namespace FizzBuzzTests.Rules
{
    public class FizzRuleTests
    {
        private FizzBuzz.Rules.FizzRule _fizzRule;

        [SetUp]
        public void SetUp()
        {
            _fizzRule = new FizzBuzz.Rules.FizzRule();
        }

        [TestCase(3, "FIZZ")]
        [TestCase(4, "")]
        [TestCase(21, "FIZZ")]
        [TestCase(999983, "")]
        public void GetWord_Called_ReturnsExpectedWord(int number, string expectedWord)
        {
            var returnedWord = _fizzRule.GetWord(number);
            Assert.That(returnedWord, Is.EqualTo(expectedWord));
        }
    }
}