using System;

namespace LAB03_WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Word Guessing Game");
            Console.WriteLine("press 1 for Play Game");
            Console.WriteLine("press 2 for Edit Game");
            Console.WriteLine("press any other key exit");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                StartGame();
            }
            else if (userInput == "2")
            {
                EditWordBank();
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }

        public static void StartGame()
        {
            bool continueGame = true;

            Game game = new Game();

            while (continueGame)
            {
                game.Reset();
                game.Play();
                Console.WriteLine("press 2 to exit, press any key to continue");
                if (Console.ReadLine() == "2")
                {
                    continueGame = false;
                }
            }
        }

        public static void EditWordBank()
        {
            bool repeat = true;
            WordBank wordBank = new WordBank();
            Console.WriteLine("Word Guessing Game Edit Menu");
            while (repeat)
            {
                string[] words = wordBank.GetAllWords();
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(words[i]);
                }
                Console.WriteLine("press 1 for Add");
                Console.WriteLine("press 2 for Delete");
                Console.WriteLine("press any key to exit");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Enter your word");
                    string word = Console.ReadLine();
                    string[] temp = { word };
                    wordBank.WriteToFile(temp);
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter word for deletion");
                    string word = Console.ReadLine();
                    bool match = false;
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                        {
                            match = true;
                            wordBank.DeleteWordFromFile(word);
                        }
                    }
                    if (match)
                    {
                        Console.WriteLine("Word delete");
                    }
                    else
                    {
                        Console.WriteLine("word does not exist");
                    }
                }
                else
                {
                    Console.WriteLine("Bye");
                    repeat = false;
                }
            }
        }
    }
}
