﻿using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
              WordCounterVowels text = new WordCounterVowels("Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500");

            Console.WriteLine(text.CountWords());

        }
    }
}
