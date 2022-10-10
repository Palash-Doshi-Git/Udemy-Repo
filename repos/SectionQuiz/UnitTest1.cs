using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SectionQuiz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            var Fahre = 1;
            var Celsius = (Fahre - 32) / 1.8;
            Console.WriteLine($"Fahren {Fahre} converted in Celsius : {Celsius} ");
            Assert.AreEqual(-17.2222222, Celsius,0.001);
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            
            var Celsius = -17.222222;
            var Fahre = (Celsius * 1.8) +32;
            Console.WriteLine($"Celsius : {Celsius}  converted in Fahren {Fahre} ");
            Assert.AreEqual(1.0000004,Fahre,0.001);
        }
    }
}
