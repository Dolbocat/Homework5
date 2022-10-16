using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public static class TextClass
    {
        readonly private static string[] separators = {",",".","-","!","?"," ",";",":"};

        public static void PrintWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        public static void NoMore(string message,int symbols) // А
        {            
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= symbols )
                {
                    Console.WriteLine(words[i]);
                }
            }       
        }

        public static void RemoveWords(string message,char n) //Б
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1] == n)
                {
                    words[i] = words[i].Remove(0, words[i].Length);                   
                }                               
            }
            string message2 = string.Join(" ", words);
            Console.WriteLine(message2);
        }

        public static void LongWord(string message) //В
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string count = " ";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > count.Length)
                {
                    count = words[i];
                }
            }
            Console.WriteLine(count);
        }

        public static void SBMessage(string message,int symbols) //Г
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= symbols)
                {
                    stringBuilder.Append(words[i] + " ");
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        public static void Identical(string word1, string word2) // не доделал пока, добью в рамках саморазвития попозже
        {
            string word3 = "";
            for (int i = 0 - 1; i <= word1.Length; i++)
            {
                if (word2[i] == word1[i])
                {

                }
            }
            if (word3.Equals(word2))
            {
                Console.WriteLine("Слова одинаковы");
            }
            else
            {
                Console.WriteLine("Слова разные");
            }
        }
    }
}
