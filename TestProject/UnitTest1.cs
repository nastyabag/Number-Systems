using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number_Systems;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        //тесты оператора сложения
        [TestMethod]
        public void TestOperatorPlus1()
        {
            Number number = new Number("1011", 2) + new Number("7261", 8);
            Assert.AreEqual("3772", number.Value);
        }

        [TestMethod]
        public void TestOperatorPlus2()
        {
            Number number = new Number(63) + new Number("D8", 16);
            Assert.AreEqual("279", number.Value);
        }
        //тесты оператора вычитания

        [TestMethod]
        public void TestOperatorMinus1()
        {
            Number number = new Number("1101010", 2) - new Number("10110", 2);
            Assert.AreEqual("84", number.Value);
        }

        [TestMethod]
        public void TestOperatorMinus2()
        {
            Number number = new Number("D1", 16) - new Number("473", 8);
            Assert.AreEqual("-106", number.Value);
        }
        //тесты оператора умножения

        [TestMethod]
        public void TestOperatorMultiply1()
        {
            Number number = new Number("0011", 2) * new Number("11", 16);
            Assert.AreEqual("51", number.Value);
        }

        [TestMethod]
        public void TestOperatorMultiply2()
        {
            Number number = new Number("26", 16) * new Number("10", 8);
            Assert.AreEqual("304", number.Value);
        }

        //тесты оператора деления
        [TestMethod]
        public void TestOperatorDivide1()
        {
            Number number = new Number("78", 16) / new Number("1001", 2);
            Assert.AreEqual("13,333333", number.Value);
        }

        [TestMethod]
        public void TestOperatorDivide2()
        {
            Number number = new Number("210", 10) / new Number("44", 8);
            Assert.AreEqual("5,8333335", number.Value);
        }
    }
}