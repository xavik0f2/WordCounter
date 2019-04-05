using System;
namespace WordCounter
{
    public class WordCounterVowels : IWordCounter
    {
        private string Text { get; set; }
        public WordCounterVowels(string text)
        {
            Text = text;
        }
        public int CountWords => new WordSplitter(Text).SplittedWords.FindAll(word => StartsWithVowel(word)).Count;

        public Boolean StartsWithVowel(string word)
        {
            word = word.ToLower();
            return word.StartsWith('a') || word.StartsWith('e') || word.StartsWith('i') || word.StartsWith('o') || word.StartsWith('u');
        }
    }
}