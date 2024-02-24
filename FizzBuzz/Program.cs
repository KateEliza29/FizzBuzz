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

            //Add rules to rule list.
            var rules = new List<Rules.IRule>();
            rules.Add(fizzRule);

            //Generate the FizzBuzzer, pass in the rules and the number range and print! 
            

            Console.Read();
        }
    }
}