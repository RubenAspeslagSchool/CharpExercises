using AdvancedTopics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.AdvancedTopic
{
    public class Exercise5CCharCount
    {
        private string _input = "iiix";
        private char _char = 'i';
        private int _ExpectedOutput = 3;
        [Fact]
        public void Result_Reverse_ReturnReversedString()
        {
            //Arrange
            //Act
            int output = _input.CountChar(_char);
            //assert
            Assert.Equal(_ExpectedOutput, output);

        }
    }
}
