using System.Xml.Linq;
using System.Linq;
using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500";

            Console.WriteLine($"Unique words: {new WordCounter(text).CountWords}");
            Console.WriteLine($"Words that begin with vowels: {new WordCounterVowels(text).CountWords}");
            Console.WriteLine($"Words with more than two characters: {new WordCounterTwoChar(text).CountWords}");
            Console.WriteLine($"Words that begin with capital: {new WordCounterCapitalCase(text).CountWords}");

        }
    }
}
