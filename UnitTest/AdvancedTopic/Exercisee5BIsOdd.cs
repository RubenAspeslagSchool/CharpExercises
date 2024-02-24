using AdvancedTopics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.AdvancedTopic
{
    public class Exercisee5BIsOdd
    {
        
        [Fact]
        public void Bool_IsOdd_ReturnTrueIfIsOddAndFalseIfIsEven()
        {
            //Arrange
            List<int> oddNumbers = new List<int>()
            {
                1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31
            };
            List<int> evenNumbers = new List<int>()
            {
                2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32
            };
            List<bool> expectedTrues = new List<bool>();
            List<bool> expectedFalses = new List<bool>();
            //Act
            oddNumbers.ForEach( number =>expectedTrues.Add(number.IsOdd()));
            evenNumbers.ForEach(number => expectedFalses.Add(number.IsOdd()));

            //assert
            expectedTrues.ForEach(i => Assert.True(i));
            expectedFalses.ForEach(i => Assert.False(i));

        }
    }
}
