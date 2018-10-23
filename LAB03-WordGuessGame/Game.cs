using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03_WordGuessGame
{
    public class Game
    {
        char [] originalGuessWord;
        char [] userGuessWord;
        
        WordBank wordBank;
        PlayerGuessHistory playerGuessHistory;

        public Game()
        {
            wordBank = new WordBank();
            playerGuessHistory = new PlayerGuessHistory();
            Reset();
        }

        public void Reset()
        {
            string word = wordBank.GenerateWord();
            originalGuessWord = word.ToCharArray();
            userGuessWord = new char[originalGuessWord.Length];
            for (int i = 0; i < originalGuessWord.Length; i++)
            {
                userGuessWord[i] = '_';
            }
            playerGuessHistory.Reset();
        }

        public void Play()
        {
            while (!CheckWinner())
            {
                Console.WriteLine("Please guess The word");
                DisplayMysteryWord();
                try
                {
                    char guessLetter = Convert.ToChar(Console.ReadLine());
                    if (Char.IsLetter(guessLetter))
                    {
                        CompareLetter(guessLetter, originalGuessWord);
                        playerGuessHistory.AddWord(guessLetter);
                    }
                } catch (Exception)
                {
                    Console.WriteLine("invalue input");
                }
                Console.WriteLine("Input History");
                playerGuessHistory.DisplayUserInputHistory();
            }

            Console.WriteLine("You figure out the word");
            DisplayMysteryWord();
        }

        public bool CompareLetter(char l, char[] guessWord)
        {
            bool correct = false;
            for(int i = 0; i < guessWord.Length; i++)
            {
                if (guessWord[i].ToString().Equals(l.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    userGuessWord[i] = guessWord[i];
                    correct = true;
                }
            }
            return correct;
        }

        public void DisplayMysteryWord()
        {
            for (int i = 0; i < userGuessWord.Length; i++)
            {
                Console.Write(userGuessWord[i] + " ");
            }
            Console.WriteLine();
        }

        public bool CheckWinner()
        {
            return !new String(userGuessWord).Contains('_');
        }
    }
}
