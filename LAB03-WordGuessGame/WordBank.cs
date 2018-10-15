using System;
using System.IO;

namespace LAB03_WordGuessGame
{
    class WordBank
    {
        string [] words;
        string WORD_FILE_PATH = "../../../Assets/words.txt";

        public WordBank()
        {
            string line;
            int counter = 0;
            StreamReader file = new StreamReader(WORD_FILE_PATH);
            while ((line = file.ReadLine()) != null)
            {
                counter++;
            }

            file.Close();
            words = new string[counter];

            file = new StreamReader(WORD_FILE_PATH);
            counter = 0;
            while ((line = file.ReadLine()) != null)
            {
                words[counter] = line;
                counter++;
            }

            file.Close();

        }

        public string GenerateWord()
        {
            Random rng = new Random();
            return words[ rng.Next(0, words.Length - 1) ];
        }
    }
}
