using System.Buffers;
using System.Security.Cryptography.X509Certificates;
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

            //TODO - Put rule generation into a separate class.
            //Find all classes implmenting the IRule interface, then instantiate them. 
            List<System.Type> ruleClasses = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
            .Where(x => typeof(Rules.IRule).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
            .Select(x => x).ToList();

            var rules = new List<Rules.IRule>();

            foreach (var ruleClass in ruleClasses)
            {
                var rule = (Rules.IRule)Activator.CreateInstance(ruleClass);
                rules.Add(rule);
            } 
            //Without this you get 'BuzzFizz' for the combined rule... 
            rules = rules.OrderBy(x => x.divisor).ToList();

            //Generate the FizzBuzzer, pass in the rules and the number range and print! 
            var numberParser = new NumberParser(rules, numbers);
            Console.WriteLine(numberParser.GetParsedNumberList());

            Console.Read();
        }
    }
}