using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EvaluationSampleCode
{
    [TestClass]
    public class MathOperationsTest
    {
        private MathOperationsTest _mathOperations;

        [TestInitialize]
        public void Setup()
        {
            _mathOperations = new MathOperationsTest();
        }

        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(200, 100, 100)]
        [DataRow(50, 30, 20)]
        public void TestSubtract(int numberOne, int numberTwo, int expectedResult)
        {

            int result = _mathOperations.Subtract(numberOne, numberTwo);


            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSubtract_ArgumentException_WhenNumberOneIsLessThanNumberTwo()
        {

            _mathOperations.Subtract(5, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSubtract_ArgumentException_WhenNumberOneIsEqualOrGreaterThan1200()
        {

            _mathOperations.Subtract(1200, 100);
        }

        [TestMethod]
        [DataRow(0, "Red")]
        [DataRow(2, "Red")]
        [DataRow(1, "Blue")]
        [DataRow(5, "Blue")]
        public void TestGetColorFromOddsNumber(int number, string expectedColor)
        {

            string result = _mathOperations.GetColorFromOddsNumber(number);

            Assert.AreEqual(expectedColor, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetColorFromOddsNumber_ArgumentException_WhenNumberIsNegative()
        {
            _mathOperations.GetColorFromOddsNumber(-1);
        }
    }
}