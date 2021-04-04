using System;
using Xunit;
using SampleCode;

namespace SampleCodeTest
{
    public class SampleTest
    {
        [Fact]
        public void Test1()
        {
            var exp = true;
            var act = Sample.IsLeapYear(2020);
            Assert.Equal(exp, act);
        }
    }
}
