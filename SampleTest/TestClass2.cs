using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest
{
    [TestFixture]
    [Parallelizable]
   // [Ignore("skip the test")]
    public class TestClass2
    {
        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("test method");
        }

        [Test]
        public void xyz()
        {
            Assert.Ignore("skip the test");
            Console.WriteLine("print xyz");
        }
    }
}
