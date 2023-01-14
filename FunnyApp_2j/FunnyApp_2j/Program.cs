using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyApp_2j
{
    internal class Program
    {

        static string[] pictures = {
        " +---+ \n" +
        "     | \n" +
        "     | \n" +
        "     | \n" +
        "    ===\n",

        " +---+ \n" +
        " 0   | \n" +
        "     | \n" +
        "     | \n" +
        "    ===\n",


        " +---+ \n" +
        " 0   | \n" +
        " |   | \n" +
        "     | \n" +
        "    ===\n",

        " +---+ \n" +
        " 0   | \n" +
        "/|   | \n" +
        "     | \n" +
        "    ===\n",

        " +---+ \n" +
        " 0   | \n" +
        "/|\\  | \n" +
        "     | \n" +
        "    ===\n",

        " +---+ \n" +
        " 0   | \n" +
        "/|\\  | \n" +
        "/    | \n" +
        "    ===\n",

        " +---+ \n" +
        " 0   | \n" +
        "/|\\  | \n" +
        "/ \\  | \n" +
        "    ===\n"
        };

        static string[] words = { "компьютер", "электроника", "футбол", "мальдивы" };

        static int numPicture = 0;

        static string userLetters = "";

        static void Main(string[] args)
        {
            string word = GetWord();
            Console.WriteLine("комп загадал слово: " + word);
            Console.WriteLine("---");

            while (true)
            {
                if (numPicture < pictures.Length)
                {
                    Console.WriteLine(pictures[numPicture]);
                }
                else
                {
                    Console.WriteLine("Вы проиграли!");
                }
                string letter = GetLetter();

                if (Contains(word, letter) == true)
                {
                    // угадали букву
                    Console.WriteLine("Такая буква есть в слове");

                    Print(userLetters);
                }
                else
                {
                    //не угадали букву
                    Console.WriteLine("Такой буквы нет в слове");
                    numPicture++;
                }
                

                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
  

            Console.ReadLine();
        }

        static void Print(string word)
        {
            for (int i = 0; i < userLetters.Length; i++)
            {
                for (int k = 0; k < word.Length; k++)
                {
                    if (userLetters[i] == word[k])
                    {
                        userLetters = userLetters + word[k];
                    }
                }
            }
        }

        static bool Contains(string word, string letter)
        {
            for (int i = 0; i < word.Length; i++)
            {
                // получаем букву из слова
                string letterInWord = word[i].ToString();
                if (letter == letterInWord)
                {
                    userLetters = userLetters + letter;
                    return true;
                }
            }
            return false;
        }

        static string GetLetter()
        {
            Console.WriteLine("Введите букву: ");
            string letter = Console.ReadLine();
            return letter;
        }

        static string GetWord()
        {
            Random r = new Random();
            int index = r.Next(0, words.Length);
            return words[index];
        }
       
    }
}
