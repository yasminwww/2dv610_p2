using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            GuessModel m = new GuessModel(random.Next(1,101));
        }
    }
}
