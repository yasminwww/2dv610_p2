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

 
    }
}