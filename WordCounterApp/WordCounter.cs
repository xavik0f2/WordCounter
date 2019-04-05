using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class WordCounter : IWordCounter
    {
        private string Text { set; get; }

        public WordCounter(string text)
        {
            Text = text;
        }

        private List<string> RemoveDuplicatedWords()
        {
            return new WordSplitter(Text).SplittedWords.Distinct().ToList();
        }

        public int CountWords
        {
            get
            {
                if (String.IsNullOrEmpty(Text))
                    return 0;

                return RemoveDuplicatedWords().Count;
            }
        }
    }
}
