using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSourceExample;

namespace TestSourceExample
{
    [TestFixture]
    public class TestSource2
    {
        [TestCaseSource("DivideCases")]
        public void DynamicSourceTest(object[] dat)
        {
            Console.WriteLine(dat[0]);
            Assert.Equals(1, 1);
        }


        private static object[] DivideCases()
        {
            var dataSetNum = 3;
            var result = new object[1];

            for (var i = 0; i < dataSetNum; i++)
            {
                result[i] = new object[] { Faker.Name.FullName() };
            }

            return result;
        }

    }


}