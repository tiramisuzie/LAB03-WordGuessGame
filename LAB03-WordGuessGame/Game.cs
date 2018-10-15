using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03_WordGuessGame
{
    class Game
    {
        char [] originalGuessWord;
        char [] userGuessWord;

        public Game(string word)
        {
            originalGuessWord = word.ToCharArray();
            userGuessWord = new char[originalGuessWord.Length];
            for(int i = 0; i < originalGuessWord.Length; i++)
            {
                userGuessWord[i] = '_';
            }
        }

        public void Play()
        {
            while (!CheckWinner())
            {
                Console.WriteLine("Please guess The word");
                for (int i = 0; i < userGuessWord.Length; i++ )
                {
                    Console.Write(userGuessWord[i] + " ");
                }
                Console.WriteLine();
                try
                {
                    char guessLetter = Convert.ToChar(Console.ReadLine());
                    if (Char.IsLetter(guessLetter))
                    {
                        CompareLetter(guessLetter);
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("invalue input");
                }
            }

            Console.WriteLine("You figure out the word");
            for (int i = 0; i < userGuessWord.Length; i++)
            {
                Console.Write(userGuessWord[i] + " ");
            }
            Console.WriteLine();
        }

        public void CompareLetter(char l)
        {
            for(int i = 0; i < originalGuessWord.Length; i++)
            {
                if ( originalGuessWord[i] == l)
                {
                    userGuessWord[i] = l;
                }
            }
        }
        public bool CheckWinner()
        {
            return !new String(userGuessWord).Contains('_');
        }
    }
}
