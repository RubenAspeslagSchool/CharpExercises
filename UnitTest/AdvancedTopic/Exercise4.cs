using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTopics;

namespace UnitTest.AdvancedTopic
{

    // conventions: https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices 
    public class Exercise4
    {

        [Fact]
        public void Exercise4IsOdd_1_ReturnTrue()
        {  
            (bool result, _) = new Exercise4PaternMaching().Run("1");
            Assert.True(result);
        }

        [Fact]
        public void Exercise4IsOdd_2_ReturnFalse()
        {
            (bool result, _) = new Exercise4PaternMaching().Run("2");
            Assert.False(result);
        }

        [Fact]
        public void Exercise4Statment_True_ReturnTrueStatement()
        {
            (_, string statment) = new Exercise4PaternMaching().Run("true");
            Assert.Equal("66 is an even number", statment);
        }

        [Fact]
        public void Exercise4Statment_False_ReturnFalseStatement()
        {
            (_, string statment) = new Exercise4PaternMaching().Run("false");
            Assert.Equal("67 is an even number", statment);
        }

        [Fact]
        public void Exercise4IsPalingdrom_Lepel_ReturnTrue()
        {
            (bool result, _) = new Exercise4PaternMaching().Run("lepel");
            Assert.True(result);
        }

        [Fact]
        public void Exercise4IsPalingdrom_The_ReturnFalse()
        {
            (bool result, _) = new Exercise4PaternMaching().Run("the");
            Assert.False(result);
        }

    }
}
