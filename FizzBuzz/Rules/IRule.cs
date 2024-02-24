namespace FizzBuzz.Rules
{
    public interface IRule
    {
        int divisor { get; }
        string GetWord(int number);
    }
}
