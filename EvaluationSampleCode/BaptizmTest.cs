using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluationSampleCode.Tests
{
    [TestClass]
    public class BaptizmTests
    {
        [TestMethod]
        public void CanBeBaptizedBy_PriestOrPope_ReturnsTrue()
        {

            var priest = new ClergyMember { IsPriest = true };
            var pope = new ClergyMember { IsPope = true };
            var baptizm = new Baptizm(priest);


            var canBeBaptizedByPriest = baptizm.CanBeBaptizedBy(priest);
            var canBeBaptizedByPope = baptizm.CanBeBaptizedBy(pope);


            Assert.IsTrue(canBeBaptizedByPriest);
            Assert.IsTrue(canBeBaptizedByPope);
        }

        [TestMethod]
        public void CanBeBaptizedBy_NonClergy_ReturnsFalse()
        {

            var nonClergy = new ClergyMember();
            var baptizm = new Baptizm(nonClergy);


            var result = baptizm.CanBeBaptizedBy(nonClergy);


            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_SameClergyMember_ReturnsTrue()
        {

            var clergy = new ClergyMember();
            var baptizm = new Baptizm(clergy);


            var result = baptizm.CanBeTeachedBy(clergy);


            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_DifferentClergyMember_ReturnsFalse()
        {

            var clergy = new ClergyMember();
            var otherClergy = new ClergyMember();
            var baptizm = new Baptizm(clergy);


            var result = baptizm.CanBeTeachedBy(otherClergy);


            Assert.IsFalse(result);
        }
    }
}