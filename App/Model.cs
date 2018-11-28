using System;
using System.Collections.Generic;

namespace App
{
    public class GuessModel
    {
        private readonly int actual;
        private List<int> guesses;
        public int possibleGuesses = 11;
    

        public GuessModel(int actual)
        {
            this.actual = actual;
            this.guesses = new List<int>();
        }

		public virtual bool IsTooHigh(int guess) 
        {
            return true;
        }
	}
}