using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03_WordGuessGame
{
    class Game
    {
        char [] guessWord;

        public Game(string word)
        {
            guessWord = word.ToCharArray(); 
        }

        public void Play()
        {

        }

        public bool checkWinner()
        {
            return false;
        }
    }
}
