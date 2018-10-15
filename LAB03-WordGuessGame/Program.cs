using System;

namespace LAB03_WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool continueGame = true;
            while(continueGame)
            {
                WordBank wordBank = new WordBank();
                Console.WriteLine();
                Game game = new Game(wordBank.GenerateWord());
                game.Play();
                Console.WriteLine("press 2 to exit, press any key to continue");
                if (Console.ReadLine() == "2" )
                {
                    continueGame = false;
                }
            }


        }
    }
}
