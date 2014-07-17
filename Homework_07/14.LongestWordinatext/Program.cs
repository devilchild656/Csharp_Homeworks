using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Longest word in a text.");
            Console.WriteLine("Write text:");
            string input = Console.ReadLine();
            string line = input.Trim('.');
            string[] list = line.Split(' ');
            string maxWord = list[0];
            foreach (string word in list)
            {
                if (word.Length > maxWord.Length)
                {
                    maxWord = word;
                }
            }
            Console.WriteLine("longest word in the text \"{0}\" is {1}.", line, maxWord);
        }
    }

