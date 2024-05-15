using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectExample1.TestExample
{

    [TestFixture]
    public class TestEx1: TestBase1
    {

        [SetUp]
        public void TestLevelSetUp()
        {
            Console.WriteLine($"Executing Test-Level: {TestContext.CurrentContext.Test.FullName} For: {TestContext.CurrentContext.Test.Name}");
        }

        [TearDown]
        public void TestCleanUp()
        {
            Console.WriteLine($"Executing Test-Level: {TestContext.CurrentContext.Test.FullName} For: {TestContext.CurrentContext.Test.Name}");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine($"========= Test Case {TestContext.CurrentContext.Test.Name} Execution ========");
            Console.WriteLine($"Executing TestCase: {TestContext.CurrentContext.Test.Name}");
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine($"========= Test Case {TestContext.CurrentContext.Test.Name} Execution ========");
            Console.WriteLine($"Executing TestCase: {TestContext.CurrentContext.Test.Name}");
        }

    }
}
