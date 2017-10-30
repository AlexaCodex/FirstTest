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
    public class TestClass
    {
        [Test]
        public void TestMethod3()
        {
            Console.WriteLine("first passing test");
        }

        [SetUp]
        public void OpenBrowser()
        {
            Console.WriteLine("opening browser");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Closing browser");
        }
    }
}
