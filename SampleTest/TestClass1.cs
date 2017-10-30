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
    public class TestClass1
    {
        [Test]
        public void TestMethod()
        {
            Console.WriteLine("TestClass1");
        }
    }
}
