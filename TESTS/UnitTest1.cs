using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_3;

namespace HW_3_TESTS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            var number = new RomanNumber(14);
            Assert.AreEqual("XIV", number.ToString());
        }

        [TestMethod]
        public void TestClone()
        {
            var number1 = new RomanNumber(14);
            RomanNumber number2 = (RomanNumber)number1.Clone();
            Assert.IsTrue(number1.CompareTo(number2) == 0);
        }

        [TestMethod]
        public void TestAdd1()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(20);
            var expected = new RomanNumber(10 + 20);
            var res = n1 + n2;
            Assert.IsTrue(res.CompareTo(expected) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestAdd2()
        {
            var n1 = new RomanNumber(12);
            RomanNumber? n2 = null;
            var res = n1 + n2;
        }

        [TestMethod]
        public void TestSub1()
        {
            var n1 = new RomanNumber(20);
            var n2 = new RomanNumber(10);
            Assert.IsTrue((n1 - n2).CompareTo(new RomanNumber(20 - 10)) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestSub2()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(20);
            var res = n1 - n2;
        }

        [TestMethod]
        public void TestMul1()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(20);
            Assert.IsTrue((n1 * n2).CompareTo(new RomanNumber(10 * 20)) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestMul2()
        {
            var n1 = new RomanNumber(10);
            RomanNumber? n2 = null;
            var res = n1 * n2;
        }

        [TestMethod]
        public void TestDiv1()
        {
            var n1 = new RomanNumber(20);
            var n2 = new RomanNumber(10);
            Assert.IsTrue((n1 / n2).CompareTo(new RomanNumber(20 / 10)) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestDiv2()
        {
            var n1 = new RomanNumber(20);
            var n2 = new RomanNumber(9);
            var res = n1 / n2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestDiv3()
        {
            var n1 = new RomanNumber(20);
            RomanNumber? n2 = null;
            var res = n1 / n2;
        }

        [TestMethod]
        public void TestCompare1()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(10);
            Assert.IsTrue(n1.CompareTo(n2) == 0);
        }

        [TestMethod]
        public void TestCompare2()
        {
            var n1 = new RomanNumber(9);
            var n2 = new RomanNumber(10);
            Assert.IsTrue(n1.CompareTo(n2) == -1);
        }

        [TestMethod]
        public void TestCompare3()
        {
            var n1 = new RomanNumber(11);
            var n2 = new RomanNumber(10);
            Assert.IsTrue(n1.CompareTo(n2) == 1);
        }
    }
}