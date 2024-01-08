using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123Assignment1;
namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestToString()
        {
            //given/arrange
            int _numerator = 2;
            int _denominator = 3;

            //when/act
            Rational rational = new Rational(_numerator, _denominator);

            //then/assert
            Assert.AreEqual("2/3", rational.ToString());
        }

        [TestMethod]
        public void TestIncreaseBy()
        {
            //given/arrange
            int _numerator = 2;
            int _denominator = 3;
            Rational r = new Rational();
            Rational r1 = new Rational(_numerator, _denominator);

            //when/act
            r.IncreaseBy(r1);

            //then/asset
            Assert.AreEqual(2, r.Numerator);
            Assert.AreEqual(3,r.Denominator);
           
        }

        [TestMethod]
        public void TestDecreaseBy()
        {
            //given/arrange
            int _numerator = 2;
            int _denominator = 3;
            Rational r = new Rational(_numerator);
            Rational r1 = new Rational(_numerator, _denominator);

            //when/act
            r.DecreaseBy(r1);

            //then/asset
            Assert.AreEqual(4, r.Numerator);
            Assert.AreEqual(3, r.Denominator);

        }

    }
}
