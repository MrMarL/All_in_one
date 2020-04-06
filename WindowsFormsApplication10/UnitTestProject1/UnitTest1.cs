using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fail()
        {
            Form1 f = new Form1();
            if (f.test(1) == 1) 
            Assert.Fail();
        }
        [TestMethod]
        public void Yspeh()
        {
            Form1 f = new Form1();
            if (f.test(0) == 1)
                Assert.Fail();
        }
    }
}
