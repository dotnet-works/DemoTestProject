using System;
using System.Collections;
using FluentAssertions;

namespace TestSourceExample
{

    [TestFixture]
    public class TestFixtureThatUsesClassAsTestCaseSource
    {
        [TestCaseSource(typeof(DivideCasesClass))]
        public void DivideTest(int n, int d, int q)
        {
            Assert.Equals(q, n / d);
        }

        [TestCaseSource(typeof (FakerDataClass))]
        public void FakerTest(String firstName,String lastName)
        {
            
            String userName = $"{ firstName} {lastName}";
            userName.Should().NotBeNullOrEmpty();
            Console.WriteLine($"User Name: {userName}");



        }



    }

    public class DivideCasesClass : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 12, 3, 4 };
            yield return new object[] { 12, 2, 6 };
            yield return new object[] { 12, 4, 3 };
        }
    }

    public class FakerDataClass : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            //yield return new object[] { Faker.Name.First(),Faker.Name.Last() };
            //yield return new object[] { Faker.Name.First(), Faker.Name.Last() };
            yield return new object[] { "Alen", "Mango" };
        }
    }
}
