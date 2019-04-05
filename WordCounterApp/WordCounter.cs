using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class WordCounter : IWordCounter
    {
        private string Text { set; get; }
        private int TotalUniqueWords { get; set; }
        public int TotalWords { get; }
        public WordCounter(string text)
        {
            Text = text;
            CountUniqueWords();
            TotalWords = TotalUniqueWords;
        }
        private void CountUniqueWords()
        {
            if (ThereIsMoreThanOneWord())
            {
                TotalUniqueWords = RemoveDuplicatedWords().Count;
                return;
            }
            if (!String.IsNullOrEmpty(Text))
            {
                TotalUniqueWords = 1;
                return;
            }
            TotalUniqueWords = 0;
        }

        private Boolean ThereIsMoreThanOneWord()
        {
            if (Text.Contains(' '))
                return true;

            return false;
        }

        private List<string> RemoveDuplicatedWords()
        {
            return SplittedWords().Distinct().ToList();
        }
         private List<string> SplittedWords()
        {
            return new List<string>(Text.Split(' '));
        }

        public int CountWords()
        {
            return this.TotalWords;
        }
    }
}
