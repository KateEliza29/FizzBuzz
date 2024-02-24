using NUnit.Framework;

namespace FizzBuzzTests.Rules
{
    public class BuzzRuleTests
    {
        private FizzBuzz.Rules.BuzzRule _buzzRule;

        [SetUp]
        public void SetUp()
        {
            _buzzRule = new FizzBuzz.Rules.BuzzRule();
        }

        [TestCase(5, "BUZZ")]
        [TestCase(7, "")]
        [TestCase(10, "BUZZ")]
        [TestCase(999983, "")]
        public void GetWord_Called_ReturnsExpectedWord(int number, string expectedWord)
        {
            var returnedWord = _buzzRule.GetWord(number);
            Assert.That(returnedWord, Is.EqualTo(expectedWord));
        }
    }
}