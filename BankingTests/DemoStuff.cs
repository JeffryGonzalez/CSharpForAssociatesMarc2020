using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class DemoStuff
    {
        [Fact]
        public void EnumeratingStuff()
        {
            var enumerableThingy = new List<char> { 'a', 'b', 'c' };
            foreach(var c in enumerableThingy)
            {
                // do something with that c
            }
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20,10,10)]
        public void SubtractionInDotNetWorks(int a, int b, int expected)
        {
            var result = a - b;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CohesionAndStuff()
        {
            var words = new List<string> { "The", "Brown", "Cow" };

            var sentence = "The Brown Cow";
            var thewords  = sentence.Split(' ');
            // ["The", "Brown","Cow"]

            var sentence2 = String.Join(' ',thewords);
            // "The Brown Cow"


        }
    }
}
