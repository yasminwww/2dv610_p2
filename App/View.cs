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

		public virtual StartMenuAction AskForAction()
        {
			return StartMenuAction.StartNew;
		}

 
    }
}