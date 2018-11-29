using System;

namespace App
{
    public class Controller
    {
        View view;
        GuessModel model;
         Random random = new Random();
        public Controller(View v, GuessModel m)
        {
           this.view = v;
           this.model = m;
        } 

        public virtual bool ActionController()
        {
            view.ShowMenu();

            // TODO: create test on PlayGame(); curently not working.
            
            View.StartMenuAction input = view.AskForAction();
            Console.Write(input);
            switch (input)
            {
                case View.StartMenuAction.StartNew:
                    view.ShowStartGuessingMessage();
                    return PlayGame();
                default:
                    return false;
            }
        }

        public virtual bool PlayGame()
        {
            return true;
            //  bool hasWon = model.HasWon();

            // do {
            //     int guess = view.GetGuessedNumber();
            //     model.GuessNumber(guess);
                
            //     if(model.IsTooHigh(guess) || model.IsTooLow(guess) || model.HasWon()) 
            //     {
            //          view.ShowGameOutcome(model.GetActual(), guess, model.GetRemainingGuesses());

            //     } 
            // }
            // while(!hasWon || model.GetRemainingGuesses() != 0);
        }
    }
}