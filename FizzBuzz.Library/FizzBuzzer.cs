using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string getvalue(int input)
        {
            string output = string.Empty;            
            string inputstr = input.ToString();
            if (input % 3 == 0 || inputstr.Contains("3"))
                output += "Fizz";
            if (input % 5 == 0 || inputstr.Contains("5"))
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();
            return output;
        }
    }
}
