using AdvancedTopics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.AdvancedTopic
{
    
    public class Exercise5
    {
        private string _input = "12345";
        private string _ExpectedOutput = "54321";
        [Fact]
        public void Result_Reverse_ReturnReversedString()
        {
            //Arrange
            //Act
            string output = _input.Reverse().ConvertToString();
            //assert
            Assert.Equal(_ExpectedOutput, output);
            
        }
    }
}
