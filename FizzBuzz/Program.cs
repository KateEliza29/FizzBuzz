using System.Buffers;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Health Partners!");

            //Generate number range. 
            var numbers = new Utils.NumberGenerator().GetNumberList(1, 100);

            //Generate rules.
            var fizzRule = new FizzRule();
            var buzzRule = new BuzzRule();

            //Add rules to rule list.
            var rules = new List<Rules.IRule>();
            rules.Add(fizzRule);
            rules.Add(buzzRule);

            //Generate the FizzBuzzer, pass in the rules and the number range and print! 
            var numberParser = new NumberParser(rules, numbers);
            Console.WriteLine(numberParser.GetParsedNumberList());

            Console.Read();
        }
    }
}