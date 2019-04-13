using System.Linq.Expressions;
using System.Collections.Generic;

namespace WordCounter
{
    public class WordCounterFilters : IWordCounter
    {
        private string Text;
        private List<string> SplittedText => new WordSplitter(Text).SplittedWords;
        public int CountWords => GetWordsByPredicate(new WordFilter(x => x.Length > 2)).Count;


        public WordCounterFilters(string text)
        {
            Text = text;
        }

        public List<string> GetWordsByPredicate(WordFilter filter)
        {
            return SplittedText.FindAll(word => filter.applyFilter(word));
        }

    }

    
}