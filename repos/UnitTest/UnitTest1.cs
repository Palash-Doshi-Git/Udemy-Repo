using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass] // attribute define the behaviour
    [TestCategory("Quiz")]
   
    public class UnitTest1
    {
        [TestMethod]

        [Description("Quiz Test demo")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(a+ b ,2);
        }

        [TestMethod]

        [Description("Quiz Test demo")]
        public void TestMethod2()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(a, b);

        }
        [TestMethod]
        [Description("Quiz Test demo")]
        public void TestMethod4()
        {
            Assert.Fail("This Test Will Always fail");
        }

        [TestMethod]
        [Description("Quiz Test demo")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var ab = 10;
            var bc = 10;
            Assert.IsTrue( ab+bc==21);

        }
    }
}
