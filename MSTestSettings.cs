using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalNumberLab1;


namespace RationalNumbers.Tests
{
    [TestClass]
    public class RationalNumberTests
    {
        [TestMethod]
        public void TestKonstructorNullDenomirator()
        {
            Assert.ThrowsException<ArgumentException>(() => new RationalNumber(5, 0));

        }

        [TestMethod]
        public void TestKonstructorCorrectConverting()
        {
            var a = new RationalNumber(2, 4);
            Assert.AreEqual("1/2", a.ToString());

            var b = new RationalNumber(5, 10);
            Assert.AreEqual("1/2", b.ToString());

            var c = new RationalNumber(-3, 9);
            Assert.AreEqual("-1/3", c.ToString());

            var d = new RationalNumber(3, -4);
            Assert.AreEqual("-3/4", d.ToString());

            var e = new RationalNumber(-2, -5);
            Assert.AreEqual("2/5", e.ToString());
        }

        [TestMethod]
        public void TestPlusOverride()
        {
            var num1 = new RationalNumber(1, 2);
            var num2 = new RationalNumber(1, 2);
            var res1 = num1 + num2;
            Assert.AreEqual("1", res1.ToString());

            var num3 = new RationalNumber(1, 3);
            var num4 = new RationalNumber(1, 6);
            var res2 = num3 + num4;
            Assert.AreEqual("1/2", res2.ToString());

            var num5 = new RationalNumber(1, -2);
            var num6 = new RationalNumber(-1, -2);
            var res3 = num5 + num6;
            Assert.AreEqual("0", res3.ToString());
        }

        [TestMethod]
        public void TestMinusOverride()
        {
            var num1 = new RationalNumber(3, 4);
            var num2 = new RationalNumber(1, 4);
            var res1 = num1 - num2;
            Assert.AreEqual("1/2", res1.ToString());

            var num3 = new RationalNumber(1, 2);
            var num4 = new RationalNumber(-1, 2);
            var res2 = num3 - num4;
            Assert.AreEqual("1", res2.ToString());

            var num5 = new RationalNumber(0, 1);
            var num6 = new RationalNumber(1, 3);
            var res3 = num5 - num6;
            Assert.AreEqual("-1/3", res3.ToString());
        }

        [TestMethod]
        public void TestMultiplOverride()
        {
            var num1 = new RationalNumber(2, 3);
            var num2 = new RationalNumber(3, 4);
            var res1 = num1 * num2;
            Assert.AreEqual("1/2", res1.ToString());

            var num3 = new RationalNumber(-1, 2);
            var num4 = new RationalNumber(2, 1);
            var res2 = num3 * num4;
            Assert.AreEqual("-1", res2.ToString());

            var num5 = new RationalNumber(0, 1);
            var num6 = new RationalNumber(5, 3);
            var res3 = num5 * num6;
            Assert.AreEqual("0", res3.ToString());
        }

        [TestMethod]
        public void TestDivOverride()
        {
            var num1 = new RationalNumber(1, 2);
            var num2 = new RationalNumber(1, 4);
            var res1 = num1 / num2;
            Assert.AreEqual("2", res1.ToString());

            var num3 = new RationalNumber(-3, 4);
            var num4 = new RationalNumber(2, 1);
            var res2 = num3 / num4;
            Assert.AreEqual("-3/8", res2.ToString());
        }

        [TestMethod]
        public void TestUnaryMinusOverride()
        {
            var num1 = new RationalNumber(3, 4);
            var res1 = -num1;
            Assert.AreEqual("-3/4", res1.ToString());

            var num2 = new RationalNumber(-1, 2);
            var res2 = -num2;
            Assert.AreEqual("1/2", res2.ToString());

            var num3 = new RationalNumber(0, 1);
            var res3 = -num3;
            Assert.AreEqual("0", res3.ToString());
        }

        [TestMethod]
        public void TestComparisonOperators()
        {
            var num1 = new RationalNumber(1, 2);
            var num2 = new RationalNumber(2, 4);
            var num3 = new RationalNumber(3, 4);

            Assert.IsTrue(num1 == num2);
            Assert.IsFalse(num1 == num3);
            Assert.IsTrue(num1 != num3);

            Assert.IsTrue(num1 < num3);
            Assert.IsTrue(num3 > num1);
            Assert.IsTrue(num1 <= num2);
            Assert.IsTrue(num3 >= num1);
        }

        [TestMethod]
        public void TestComparisonWithNegativeNumbers()
        {
            var num1 = new RationalNumber(-1, 2);
            var num2 = new RationalNumber(1, -2);
            var num3 = new RationalNumber(-3, 4);

            Assert.IsTrue(num1 == num2);

            Assert.IsTrue(num1 > num3);
        }
        
        [TestMethod]
        public void TestDivByZero()
        {
            var num1 = new RationalNumber(1, 2);
            var zero = new RationalNumber(0, 1);

            Assert.ThrowsException<DivideByZeroException>(() => num1 / zero);
        }

        [TestMethod]
        public void TestTest()
        {
            var num1 = new RationalNumber(1, 2);
            var num2 = new RationalNumber(0, 2);


            Assert.ThrowsException<DivideByZeroException>(() => num1 / num2);


        }




    }
}

