using System;
using Xunit;
using Prime.Services;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            Assert.True(true);
        }

	[Fact]
	public void CanCreateInstance()
	{
		var service = new PrimeService();
		Assert.NotNull(service);
	}
    }
}
