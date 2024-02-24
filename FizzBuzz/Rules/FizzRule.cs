namespace FizzBuzz.Rules
{
    public class FizzRule : IRule
    {
        public int divisor { get => 3; }
        public string GetWord(int number) 
        {
            return "FIZZ";
        }
    }
}