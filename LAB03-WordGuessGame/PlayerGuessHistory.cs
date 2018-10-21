using System;

namespace LAB03_WordGuessGame
{
    public class PlayerGuessHistory
    {

        string userInputHistory = "";

        public void Reset()
        {
            userInputHistory = "";
        }

        public void AddWord(char letter)
        {
            userInputHistory += letter;
        }

        public void DisplayUserInputHistory()
        {
            for (int i = 0; i < userInputHistory.Length; i++)
            {
                Console.Write(userInputHistory[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
