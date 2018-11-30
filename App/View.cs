using System;
using System.Collections.Generic;

namespace App
{

    public class View
    {
      public int guess;
        
        public char choice;

        public IConsole console;
        public GuessModel model;

		public enum StartMenuAction
       {
           Exit,
           StartNew
       }

		public View(IConsole console, GuessModel gm)
        {
            this.console = console;
            this.model = gm;
        }

        public virtual void ShowMenu()
        {
            this.console.WriteLine("Hello, Would you like to start a New Game?\n 'p' = Play\n 'e' = Exit");
        }

		public virtual StartMenuAction AskForAction()
        {
			int count = 0;
            char input = this.console.ReadKey();
			while (input != 'p' && input != 'e' && count < 3)
            {
                this.console.WriteLine("Invalid choice, try again.");
                input = this.console.ReadKey();
                count++;
            }
			return (input == 'p') ? StartMenuAction.StartNew : StartMenuAction.Exit;
		}

        public virtual void ShowStartGuessingMessage()
        {
            this.console.WriteLine("Enter a number between 1 & 100..\n");
        }

        public virtual int GetGuessedNumber()
        { 
            int input;
            string rawStringInput = console.ReadLine();
            int.TryParse(rawStringInput, out input);

            return input;
        }


        public virtual void ShowGameOutcome(int actual, int guess, int guessesLeft)
        {
			if (guessesLeft == 0)
            {
				console.WriteLine($"You Lost, this time!!");
            }
			else if (model.HasWon())
			{
                console.WriteLine($"Congrats!! You guessed it!! The right answer is {actual}.");

			}
			 else if (model.IsTooHigh(guess))
            {
                console.WriteLine($"Your guess is Too High. Guesses left: ({guessesLeft})");
            } 
			else
			{
				console.WriteLine($"Your guess is Too Low. Guesses left: ({guessesLeft})");
			}
		}
    }
}