using System;
using Xunit;
using LAB03_WordGuessGame;
using System.IO;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldCreateFile()
        {
            WordBank wordBank = new WordBank();

            bool result = wordBank.CreateFile();

            Assert.True(result);

            wordBank.DeleteFile();
        }

        [Fact]
        public void FileCanBeUpdated()
        {
            string[] word = { "test" };

            WordBank wordBank = new WordBank();
            wordBank.WordBankCounter = 0;
            wordBank.CreateFile();
            wordBank.WriteToFile(word);
            
            string result = wordBank.GenerateWord();

            Assert.Equal(1, wordBank.WordBankCounter);
            Assert.Equal(word[0], result);

            wordBank.DeleteFile();
        }

        [Fact]
        public void FileCanBeDeleted()
        {
            WordBank wordBank = new WordBank();
            wordBank.CreateFile();

            bool result = wordBank.DeleteFile();
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnAWordInFile()
        {
            string[] word = { "test" };

            WordBank wordBank = new WordBank();
            wordBank.WordBankCounter = 0;
            wordBank.CreateFile();
            wordBank.WriteToFile(word);

            string result = wordBank.GenerateWord();

            Assert.Equal(1, wordBank.WordBankCounter);
            Assert.Equal(word[0], result);

            wordBank.DeleteFile();
        }

        [Fact]
        public void ShouldReturnAllWordsFromFile()
        {
            string[] word = { "test1", "test2" };
            WordBank wordBank = new WordBank();
            wordBank.CreateFile();
            wordBank.WriteToFile(word);

            string[] result = wordBank.GetAllWords();
            Assert.Equal(word[0], result[0]);
            Assert.Equal(word[1], result[1]);
        }

        [Fact]
        public void ShouldKnowWhenLetterExist()
        {
            Game game = new Game();
            char[] word = "Gumiho".ToCharArray();
            bool result = game.CompareLetter('g', word);
            Assert.True(result);
        }

        [Fact]
        public void ShouldKnowWhenLetterNotExist()
        {
            Game game = new Game();
            char[] word = "Gumiho".ToCharArray();
            bool result = game.CompareLetter('a', word);
            Assert.False(result);
        }

        [Fact]
        public void ShouldDeleteWordFromFile()
        {
            string[] word = { "test1", "test2" };
            WordBank wordBank = new WordBank();
            wordBank.CreateFile();
            wordBank.WriteToFile(word);
            wordBank.DeleteWordFromFile("test1");
            string[] result = wordBank.GetAllWords();
            Assert.Single(result);
            Assert.Equal(word[1], result[0]);

        }
    }
}
