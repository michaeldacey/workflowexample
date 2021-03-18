using System;
using Xunit;
using CodeExampleProject;

namespace XunitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AdderInitTest()
        {
			int expectedValue = 0;
			Adder adder = new Adder();
			Assert.Equal(expectedValue, adder.Total);
        }
		
		[Fact]
        public void AdderAddTest()
        {
			int expectedValue = 5;
			Adder adder = new Adder();
			adder.Add(3);
			adder.Add(2);
			Assert.Equal(expectedValue, adder.Total);
        }
		
		[Fact]
        public void AdderResetTest()
        {
			int expectedValue = 0;
			Adder adder = new Adder();
			adder.Add(4);
			adder.Reset();
			Assert.Equal(expectedValue, adder.Total);
        }
    }
}
