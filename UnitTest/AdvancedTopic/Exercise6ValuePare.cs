using AdvancedTopics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTopics;
using System.Data;

namespace UnitTest.AdvancedTopic
{
   
    public class Exercise6ValuePare
    {
        // welke methode test je
        // beschrijving
        // welk resultaat verwacht je
        [Fact]   
        public void TestAdd()
        {
            //Arrange
            Exercise6KeyValuePairList<string,string> exercise6ValuePare = new Exercise6KeyValuePairList<string, string>();


            //Act
            exercise6ValuePare.Add("ik ben Ruben", "soy Ruben");

            //assert
            Assert.Single(exercise6ValuePare.Values);
            Assert.Single(exercise6ValuePare.Keys);
            Assert.Equal(1, exercise6ValuePare.Count);
            Assert.Equal("soy Ruben", exercise6ValuePare.Values[0]);
            Assert.Equal("ik ben Ruben", exercise6ValuePare.Keys[0]);
            Assert.True(true);
        }


        [Fact]
        public void TestClear()
        {
            //Arrange
            Exercise6KeyValuePairList<string, string> exercise6ValuePare = new Exercise6KeyValuePairList<string, string>();
            exercise6ValuePare.Add("ik ben Ruben", "soy Ruben");
            exercise6ValuePare.Add("apel", "manzana");
            //Act
            exercise6ValuePare.Clear();

            //assert
            Assert.Empty(exercise6ValuePare.Values);
            Assert.Empty(exercise6ValuePare.Keys);
            Assert.Equal(0, exercise6ValuePare.Count);
            Assert.True(true);
        }

        [Fact]
        public void TestRemove()
        {
            //Arrange
            Exercise6KeyValuePairList<string, string> exercise6ValuePare = new Exercise6KeyValuePairList<string, string>();
            exercise6ValuePare.Add("ik ben Ruben", "soy Ruben");
            exercise6ValuePare.Add("apel", "manzana");
            //Act
            exercise6ValuePare.Remove("ik ben Ruben");

            //assert
            //Assert.Single(exercise6ValuePare.Values);
            //Assert.Single(exercise6ValuePare.Keys);
            //Assert.Equal(1, exercise6ValuePare.Count);
            //Assert.Equal("apel", exercise6ValuePare.Values[0]);
            //Assert.Equal("manzana", exercise6ValuePare.Keys[0]);
            //Assert.True(true);
        }
    }
}
