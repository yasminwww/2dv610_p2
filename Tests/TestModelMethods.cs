using System;
using Xunit;
using App;

namespace Tests
{
	public class TestModelMethods
	{
        [Theory]
        [InlineData(18)]
        public void ShouldReturnTrue_isTooHigh(int x)
        {
            var sut = new GuessModel(x);
            Assert.Equal(true, sut.IsTooHigh(200));
        }

  	}
}