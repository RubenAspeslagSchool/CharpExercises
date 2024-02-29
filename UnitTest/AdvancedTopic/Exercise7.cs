using AdvancedTopics;
using System;
using System.Collections.Generic;
// using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.AdvancedTopic
{
    public class Exercise7
    {

        [Fact]
        public void Result_Extentions_ReturnIEnumerable()
        {
            //Arrange
            IEnumerable<int> numbers = new List<int>() { 5, 67, 23, 8, 45 };
            // Act
            numbers
            .WhereEx7(n => n > 15) //your own extension method
            .ToListEx7() //your own extension method
            .ForEachEx7(n => Console.WriteLine(n)); //your own extension method
            // Assert
        }

    }
}
