using System.Collections.Generic;

namespace WordCounter
{

    public class WordSplitter
    {
        private string Text { get; set; }

        public WordSplitter(string text)
        {
            Text = text;
        }

        public List<string> SplittedWords => new List<string>(Text.Split(' '));
    }

}