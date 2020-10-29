using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using elinder2f1;
namespace elinder2f1UnitTests
{
    [TestClass]
    public class Ex2f1UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            public void Test01AInputGE100()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc01("100.0"));
            }
            [TestMethod]
            public void Test01AInputLT100()
            {
                Assert.AreEqual("0.00", Ex2fCalculations.Calc01("99.99"));
            }
            [TestMethod]
            public void Test02AInputGE100()
            {
                Assert.AreEqual("Bulk rate: 0.20", Ex2fCalculations.Calc02("100.00"));
            }
            [TestMethod]
            public void Test02AInputLT100()
            {
                Assert.AreEqual("Standard rate: ", Ex2fCalculations.Calc02("99.99"));
            }
            [TestMethod]
            public void Test03AInputGE100()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc03("100.00"));
            }
            [TestMethod]
            public void Test03AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc03("99.99"));
            }
            [TestMethod]
            public void Test04AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc04("99.99"));
            }
            [TestMethod]
            public void Test04AInputGE100LT200A()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc04("100.00"));
            }
            [TestMethod]
            public void Test04AInputGE100LT200B()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc04("199.99"));
            }
            [TestMethod]
            public void Test04AInputGE200LT300A()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc04("200.00"));
            }
            [TestMethod]
            public void Test04AInputGE200LT300B()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc04("299.99"));
            }
            [TestMethod]
            public void Test04AInputGE300()
            {
                Assert.AreEqual("0.40", Ex2fCalculations.Calc04("300.00"));
            }
            [TestMethod]
            public void Test05AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc05("99.99"));
            }
            [TestMethod]
            public void Test05AInputGE100LT200A()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc05("100.00"));
            }
            [TestMethod]
            public void Test05AInputGE100LT200B()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc05("199.99"));
            }
            [TestMethod]
            public void Test05AInputGE200LT300A()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc05("200.00"));
            }
            [TestMethod]
            public void Test05AInputGE200LT300B()
            {
                Assert.AreEqual("0.30", Ex2fCalculations.Calc05("299.99"));
            }
            [TestMethod]
            public void Test05AInputGE300()
            {
                Assert.AreEqual("0.40", Ex2fCalculations.Calc05("300.00"));
            }
            [TestMethod]
            public void Test06AInputLT100()
            {
                Assert.AreEqual("0.10", Ex2fCalculations.Calc06("99.99", "R"));
            }
            [TestMethod]
            public void Test06AInputGE100LT200A()
            {
                Assert.AreEqual("0.20", Ex2fCalculations.Calc06("100.00", "R"));
            }
            [TestMethod]
            public void Test06BInputNotR()
            {
                Assert.AreEqual("0.40", Ex2fCalculations.Calc06("100.00", "Z"));
            }
        }
    }
