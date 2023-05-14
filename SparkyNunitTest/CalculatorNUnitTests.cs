using NUnit.Framework;


namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calcu = new Calculator();

            //Act
            int resutl = calcu.AddNums(10, 30);

            //Assert
            Assert.AreEqual(40, resutl);
        
        }

        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        public void IsOddNumber_InputEven_ReturnFalse(int a)
        {
            Calculator calcu1 = new Calculator();
            bool isOdd = calcu1.IsOddNumber(a);
            Assert.That(isOdd, Is.False);
            //OR
            Assert.IsFalse(isOdd);
        }

        //Testing multiple values
        [Test]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(15)]
        public void IsOddNumber_InputEven_ReturnTrue(int a)
        {
            Calculator calcu1 = new Calculator();
            bool isOdd = calcu1.IsOddNumber(a);
            Assert.That(isOdd, Is.True);
            //OR
            Assert.IsTrue(isOdd);
        }

        //Combine Unit Test with Expected Result
        [Test]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(10, ExpectedResult = false)]
        public bool isOdd_InputNumber_ReturnTrueifOdd(int a)
        {
            Calculator calcu = new Calculator();
            return calcu.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4,10.5)] 
        [TestCase(5.43,10.53)]
        [TestCase(5.49,10.59)]
        //009 Asseting Doubles
        public void AddNumbers_InputTwodouble_GetCorrectAddition(double a, double b)
        {
            //Arrange
            Calculator calcu = new Calculator();

            //Act
            double resutl = calcu.AddNumsdouble(a, b);

            //Assert
            Assert.AreEqual(15.9, resutl,1);

        }

        [Test]
        public void OddRanger_InMaxAndMin_ReturnValidOddRanger()
        {
            Calculator calcu = new Calculator();
            List<int> expectedOddRange = new() { 5,7,9};
            List<int> result = calcu.OddRange(5, 10);
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
        }

    }
}
