using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectExample1.TestExample
{
    //[SetUpFixture]
    public class TestBase1
    {

        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            Console.WriteLine($"Executing Global OneTimeSetUp: {TestContext.CurrentContext.Test.FullName} For: {TestContext.CurrentContext.Test.Name}");
        }

        [SetUp]
        public void InitTest()
        {
            Console.WriteLine($"Executing Global SetUp: {TestContext.CurrentContext.Test.FullName} For: {TestContext.CurrentContext.Test.Name}");
        }

        [TearDown]
        public void CleanUpTest()
        {
            Console.WriteLine($"Executing Global TearDown: {TestContext.CurrentContext.Test.FullName} For: {TestContext.CurrentContext.Test.Name}");
        }

        [OneTimeTearDown]
        public void GlobalTearDown() 
        {
            Console.WriteLine($"Executing Global OneTimeTearDown: {TestContext.CurrentContext.Test.FullName} For: {TestContext.CurrentContext.Test.Name}");
        }
        
    }
}
