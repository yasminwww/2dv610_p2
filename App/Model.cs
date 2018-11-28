using System;
using System.Collections.Generic;

namespace App
{
    public class GuessModel
    {
        private readonly int actual;
        private List<int> guesses;
        public int remainingGuesses = 11;
    

        public GuessModel(int actual)
        {
            this.actual = actual;
            this.guesses = new List<int>();
        }
        public void GuessNumber(int guess)
        {
            this.guesses.Add(guess);
        }
		public virtual bool HasWon()
        {
            return guesses.Contains(actual);
        }
		public virtual bool IsTooHigh(int guess) 
        {
            return guess > actual;
        }

		public int GetRemainingGuesses()
		{
			return remainingGuesses -1;
		}

		public virtual int GetActual()
        {
            return 0;
        }
	}
}