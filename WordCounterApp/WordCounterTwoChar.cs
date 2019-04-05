using System.Collections.Generic;

namespace WordCounter
{
    public class WordCounterTwoChar : IWordCounter
    {
        private string Text;
        public WordCounterTwoChar(string text)
        {
            this.Text = text;
        }
        public int CountWords()
        {
            return new WordSplitter(Text).SplittedWords
            .FindAll(word => word.Length > 2).Count;
        }
    }
}