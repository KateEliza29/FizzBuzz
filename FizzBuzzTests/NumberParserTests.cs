using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace FizzBuzzTests
{
    public class NumberParserTests
    {
        private FizzBuzz.NumberParser GenerateNumberParser(int startNumber, int endNumber) 
        {
            var numbers = new FizzBuzz.Utils.NumberGenerator().GetNumberList(startNumber, endNumber);
            var rules = new List<FizzBuzz.Rules.IRule>();
            rules.Add(new FizzBuzz.Rules.FizzRule());
            return new FizzBuzz.NumberParser(rules, numbers);
        }

        [TestCase(1, 10, "1, 2, FIZZ, 4, 5, FIZZ, 7, 8, FIZZ, 10")]
        [TestCase(10, 15, "10, 11, FIZZ, 13, 14, FIZZ")]
        public void PrintParsedNumberList_Called_ReturnsExpectedString(int startNumber, int endNumber, string expectedString)
        {
            var numberParser = GenerateNumberParser(startNumber, endNumber);
            var parsedList = numberParser.GetParsedNumberList();
            Assert.That(parsedList, Is.EqualTo(expectedString));
        }
    }
}