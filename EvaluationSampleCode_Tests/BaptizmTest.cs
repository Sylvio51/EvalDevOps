using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode_Tests
{
    public class BaptizmTests
    {
        public void CanBeBaptizedBy_Priest_ReturnsTrue()
        {
            var priest = new ClergyMember { IsPriest = true, IsPope = false };
            var baptizm = new Baptizm(priest);

            Assert.IsTrue(baptizm.CanBeBaptizedBy(priest));
        }

        public void CanBeBaptizedBy_Pope_ReturnsTrue()
        {
            var pope = new ClergyMember { IsPriest = false, IsPope = true };
            var baptizm = new Baptizm(pope);

            Assert.IsTrue(baptizm.CanBeBaptizedBy(pope));
        }

        public void CanBeBaptizedBy_NeitherPriestNorPope_ReturnsFalse()
        {
            var layman = new ClergyMember { IsPriest = false, IsPope = false };
            var baptizm = new Baptizm(layman);

            Assert.IsFalse(baptizm.CanBeBaptizedBy(layman));
        }

        public void CanBeTeachedBy_CorrectClergyMember_ReturnsTrue()
        {
            var clergyMember = new ClergyMember { IsPriest = true, IsPope = false };
            var baptizm = new Baptizm(clergyMember);

            Assert.IsTrue(baptizm.CanBeTeachedBy(clergyMember));
        }

        public void CanBeTeachedBy_IncorrectClergyMember_ReturnsFalse()
        {
            var creator = new ClergyMember { IsPriest = true, IsPope = false };
            var anotherClergy = new ClergyMember { IsPriest = false, IsPope = true };
            var baptizm = new Baptizm(creator);

            Assert.IsFalse(baptizm.CanBeTeachedBy(anotherClergy));
        }

        public void CanBeTeachedBy_NullClergyMember_ReturnsFalse()
        {
            var creator = new ClergyMember { IsPriest = true, IsPope = false };
            var baptizm = new Baptizm(creator);

            Assert.IsFalse(baptizm.CanBeTeachedBy(null));
        }
    }
}
