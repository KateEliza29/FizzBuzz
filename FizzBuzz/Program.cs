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

            //Add rules to rule list.

            //Generate the FizzBuzzer, pass in the rules and the number range and print! 

            Console.Read();
        }
    }
}