using System;

namespace LAB03_WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            WordBank wordBank = new WordBank();
            Console.WriteLine();
            Game game = new Game(wordBank.GenerateWord());

            game.Play();


        }
    }
}
