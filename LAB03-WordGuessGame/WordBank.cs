using System;
using System.IO;

namespace LAB03_WordGuessGame
{
    public class WordBank
    {
        string[] initialWords = { "Gumiho", "furry", "nose", "paw"};
        string WORD_FILE_PATH = @"C:\Users\suhys\source\repos\LAB03-WordGuessGame\LAB03-WordGuessGame\Assets\words.txt";

        public int WordBankCounter { get; set; }

        public WordBank()
        {
            CreateFile();
            WriteToFile(initialWords);
        }

        public string GenerateWord()
        {
            string[] words = GetAllWords();

            Random rng = new Random();
            return words[ rng.Next(0, words.Length - 1) ];
        }

        public string[] GetAllWords()
        {
            return File.ReadAllLines(WORD_FILE_PATH);
        }

        public bool CreateFile()
        {
            FileStream fileStream = File.Create(WORD_FILE_PATH);
            fileStream.Close();
            return File.Exists(WORD_FILE_PATH);
        }

        public void WriteToFile(string [] words)
        {
            WordBankCounter = WordBankCounter + words.Length;
            File.AppendAllLines(WORD_FILE_PATH, words);
        }

        public bool DeleteFile()
        {
            File.Delete(WORD_FILE_PATH);
            return !File.Exists(WORD_FILE_PATH);
        }

        public void DeleteWordFromFile(string word)
        {
            string[] words = GetAllWords();
            string[] newWords = new string[words.Length-1];
            int counter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                {
                    newWords[counter] = words[i];
                    counter++;
                }
            }
            CreateFile();
            WriteToFile(newWords);
        }
    }
}
