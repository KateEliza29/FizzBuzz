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
            //TODO - Neaten the formatting and comma separate.
            var parsedNumbers = "";
            foreach (var number in _numbers)
            {
                var matched = false;
                foreach (var rule in _rules)
                {                       
                    var parsedValue = rule.GetWord(number);
                    if (!string.IsNullOrEmpty(parsedValue)) 
                    {
                        matched = true;
                        parsedNumbers += parsedValue;
                    }
                    if (!matched)
                        parsedNumbers += $"{number.ToString()} ";
                    else 
                        parsedNumbers += " ";
                }
            }
            return parsedNumbers.Trim();
        }
    }
}