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

            switch (input)
            {
                case View.StartMenuAction.StartNew:
                view.ShowStartGuessingMessage();
                // return true;

                PlayGame();
                return true;
                
                default: return false;
            }
        }

        public virtual bool PlayGame()
        {
            return true;
        }
    }
}