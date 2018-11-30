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
            Assert.True(sut.IsTooHigh(200));
        }


		[Theory]
		[InlineData(2, 1)]
		[InlineData(18, -22)]
		[InlineData(23, 5)]
		[InlineData(45, 8)]
		public void ShouldReturnFalse_isTooHigh(int x, int y)
		{
			var sut = new GuessModel(x);
			Assert.False(sut.IsTooHigh(y));
		}

		
        [Theory]
        [InlineData(23, 23)]
        [InlineData(2, 2)]
        public void ShouldReturnTrueOnMatch_HasWon(int x, int y)
        {
            var sut = new GuessModel(y);
            sut.GuessNumber(x);
            Assert.True(sut.HasWon());
		}

		
        [Theory]
        [InlineData(25, 23)]
        [InlineData(-25, 2)]
        [InlineData(1, 55)]
        public void ShouldReturnFalse_HasWon(int x, int y)
        {
            var sut = new GuessModel(y);
            sut.GuessNumber(x);
            Assert.False(sut.HasWon());
        }


		[Theory]
        [InlineData(25, 76, 4, 23)]
        [InlineData(-2, 09, 45, 7)]
        public void ShouldReturnFalseOnMismatch_HasWon(int x, int y, int z, int m)
        {
            var sut = new GuessModel(m);
            sut.GuessNumber(x);
            sut.GuessNumber(y);
            sut.GuessNumber(z);
            Assert.False(sut.HasWon());
        }


        [Theory]
        [InlineData(1, 87)]
        public void ShouldReturnRemaining_SetRemainingGuesses(int x, int y)
        {
            var sut = new GuessModel(y);
            sut.GuessNumber(x);
            sut.SetRemainingGuesses();
            var actual = sut.GetRemainingGuesses();
            Assert.Equal(10, actual);
        }

		[Theory]
        [InlineData(25, 23)]
        public void ShouldReturnRemaining_GetRemainingGuesses(int x, int m)
        {
            var sut = new GuessModel(m);
            sut.GuessNumber(x);
            var actual = sut.SetRemainingGuesses();
            Assert.Equal(10, actual);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(-67)]
        [InlineData(100)]
        public void ShouldReturnActual_GetActual(int m)
        {
            var sut = new GuessModel(m);
            var actual = sut.GetActual();
            Assert.Equal(m, actual);
        }
	}
}