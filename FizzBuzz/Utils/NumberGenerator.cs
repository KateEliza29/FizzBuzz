using System.Collections.Generic;

namespace FizzBuzz.Utils
{
    public class NumberGenerator
    {
        public IEnumerable<int> GetNumberList(int startNumber, int endNumber) 
        {
            //TODO - refactor to only have one return.
            if (startNumber > 0 && endNumber > 0)
                return Enumerable.Range(startNumber, (endNumber+1) - startNumber).ToArray();
            else 
                return new List<int>();
        }
    }
}