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
    }
}