namespace UnitTest.AdvancedTopic
{
    using CsharpAfterJava.Exercise1;
    public class FactorialTest
    {
        private int _startValue = 5;
        private int _resultValue = 120;
        [Fact]
        public void Result_RactorialCountWithPropertyValue_ReturnCorrectResult()
        {
            //Arrange
            FactorialE fac = new FactorialE(_startValue);
            // Act
            long result = fac.Result;
            // Assert
            Assert.Equal(_resultValue, result);
        }
    }
}