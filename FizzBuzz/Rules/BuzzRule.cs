namespace FizzBuzz.Rules
{
    public class BuzzRule : IRule
    {
        public int divisor { get => 5; }
        public string GetWord(int number) 
        {
            if (number % divisor == 0)
                return "BUZZ";
            else 
                return "";
        }
    }
}