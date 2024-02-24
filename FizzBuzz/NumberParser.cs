namespace FizzBuzz
{
    public class NumberParser
    {
        private IEnumerable<Rules.IRule> _rules;
        private IEnumerable<int> _numbers;

        public NumberParser(IEnumerable<Rules.IRule> rules, IEnumerable<int> numbers)
        {
            _rules = rules;
            _numbers = numbers;
        }

        public string GetParsedNumberList() 
        {
            return "None shall pass!";
        }
    }
}