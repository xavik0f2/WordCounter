using System;
namespace WordCounter
{
    public class WordCounterCapitalCase : IWordCounter
    {
        private string Text { get; set; }

        public WordCounterCapitalCase(string text)
        {
            Text = text;
        }
        public int CountWords => new WordSplitter(Text).SplittedWords.FindAll(word => StartsWithCapitalCase(word)).Count;

        public Boolean StartsWithCapitalCase(string word)
        {
            if (word.Length == 0)
                return false;

            return char.IsUpper(word, 0);
        }
    }
}