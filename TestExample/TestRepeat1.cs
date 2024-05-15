using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectExample1.TestExample
{

    [TestFixture]
    public class TestRepeat1:TestBase1
    {

        [SetUp]
        public void InitTest()
        {

        }

        [TearDown]
        public void Cleanup() 
        { 
        }

        [Test]
        [Repeat(2)]
        public void Test1()
        {
            Console.WriteLine("Test Class");
        }
    
    }
}
