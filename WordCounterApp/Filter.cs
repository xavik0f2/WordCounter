using System;

namespace WordCounter

{
    public class WordFilter
    {
        private Func<string, bool> lambda;

        public WordFilter(Func<string, bool> lambda)
        {
            this.lambda = lambda;
        }

        public bool applyFilter(string word)
        {
            return lambda.Invoke(word);
        }

    }
}