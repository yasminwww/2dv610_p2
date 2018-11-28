using System;
using Xunit;
using App;

namespace Tests
{
	public class TestModelMethods
	{
        [Theory]
        [InlineData(18)]
        [InlineData(-99)]
        [InlineData(54)]
        [InlineData(12)]

        public void ShouldReturnTrue_isTooHigh(int x)
        {
            var sut = new GuessModel(x);
            Assert.Equal(true, sut.IsTooHigh(200));
        }


		[Theory]
		[InlineData(2, 1)]
		[InlineData(18, -22)]
		[InlineData(23, 5)]
		[InlineData(45, 8)]
		public void ShouldReturnFalse_isTooHigh(int x, int y)
		{
			var sut = new GuessModel(x);
			Assert.Equal(false, sut.IsTooHigh(y));
		}

		
        [Theory]
        [InlineData(23, 23)]
        [InlineData(2, 2)]
        public void ShouldReturnTrueOnMatch_HasWon(int x, int y)
        {
            var sut = new GuessModel(y);
            sut.GuessNumber(x);
            Assert.Equal(true, sut.HasWon());
        }
	}

}