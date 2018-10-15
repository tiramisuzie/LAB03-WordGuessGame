using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03_WordGuessGame
{
    class Game
    {
        char [] guessWord;
        char[] userGuessLetter;

        public Game(string word)
        {
            guessWord = word.ToCharArray();
            userGuessLetter = new char[guessWord.Length];
            for(int i = 0; i < guessWord.Length; i++)
            {
                userGuessLetter[i] = '_';
            }
        }

        public void Play()
        {
            while (!CheckWinner())
            {
                Console.WriteLine("Please guess The word");
                for (int i = 0; i < userGuessLetter.Length; i++ )
                {
                    Console.Write(userGuessLetter[i] + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        public bool CheckWinner()
        {
            return false;
        }
    }
}
