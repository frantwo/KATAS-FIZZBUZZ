using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
         [Test]
        public void BuzzerWhenDefaultReturnsInput(
            [Values(1,2,4,7,8,11,13,14,16)] int input)
         {
            
            string output = FizzBuzzer.getvalue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void BuzzerWhenDiv3ReturnsFizz(
            [Values(3,6,9,12)] int input)
        {
            string output = FizzBuzzer.getvalue(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void BuzzerWhenDiv5ReturnsBuzz(
            [Values(5,10)] int input)
        {
            string output = FizzBuzzer.getvalue(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void BuzzerWhenDiv3and5ReturnsFizzBuzz(
            [Values(15)] int input)
        {
            string output = FizzBuzzer.getvalue(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
