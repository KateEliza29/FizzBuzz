using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace FizzBuzzTests
{
    public class NumberParserTests
    {
        private FizzBuzz.NumberParser GenerateNumberParser(int startNumber, int endNumber, string ruleType) 
        {
            var numbers = new FizzBuzz.Utils.NumberGenerator().GetNumberList(startNumber, endNumber);
            var rules = new List<FizzBuzz.Rules.IRule>();
            if (ruleType == "fizz") 
            {
                rules.Add(new FizzBuzz.Rules.FizzRule());
            }
            else if (ruleType == "buzz") 
            {
                rules.Add(new FizzBuzz.Rules.BuzzRule());
            }
            else if (ruleType == "fizzbuzz") 
            {
                rules.Add(new FizzBuzz.Rules.FizzRule());
                rules.Add(new FizzBuzz.Rules.BuzzRule());
            }
            return new FizzBuzz.NumberParser(rules, numbers);
        }

        [TestCase(1, 10, "1 2 FIZZ 4 5 FIZZ 7 8 FIZZ 10")]
        [TestCase(10, 15, "10 11 FIZZ 13 14 FIZZ")]
        public void GetParsedNumberList_CalledWithFizz_ReturnsExpectedString(int startNumber, int endNumber, string expectedString)
        {
            var numberParser = GenerateNumberParser(startNumber, endNumber, "fizz");
            var parsedList = numberParser.GetParsedNumberList();
            Assert.That(parsedList, Is.EqualTo(expectedString));
        }

        [TestCase(1, 21, "1 2 3 4 BUZZ 6 7 8 9 BUZZ 11 12 13 14 BUZZ 16 17 18 19 BUZZ 21")]
        public void GetParsedNumberList_CalledWithBuzz_ReturnsExpectedString(int startNumber, int endNumber, string expectedString)
        {
            var numberParser = GenerateNumberParser(startNumber, endNumber, "buzz");
            var parsedList = numberParser.GetParsedNumberList();
            Assert.That(parsedList, Is.EqualTo(expectedString));
        }

        [TestCase(1, 16, "1 2 FIZZ 4 BUZZ FIZZ 7 8 FIZZ BUZZ 11 FIZZ 13 14 FIZZBUZZ 16")]
        public void GetParsedNumberList_CalledWithFizzBuzz_ReturnsExpectedString(int startNumber, int endNumber, string expectedString)
        {
            var numberParser = GenerateNumberParser(startNumber, endNumber, "fizzbuzz");
            var parsedList = numberParser.GetParsedNumberList();
            Assert.That(parsedList, Is.EqualTo(expectedString));
        }
    }
}