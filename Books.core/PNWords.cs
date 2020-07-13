using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Books.core
{
    public class PNWords
    {
        public HashSet<string> Negetive = new HashSet<string>();
        public HashSet<string> Positive = new HashSet<string>();
        public PNWords()
        {
            AllNegative();
            AllPositive();
        }
        private void AllNegative()
        {
            string nPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "words\\negative-words.txt");
            if(Negetive.Count == 0)
            {
                string[] negativeWords = File.ReadAllLines(nPath);
                foreach(string s in negativeWords)
                    Negetive.Add(s);
            }
        }
        private void AllPositive()
        {
            string pPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "words\\positive-words.txt");
            if(Positive.Count == 0)
            {
                string[] positiveWords = File.ReadAllLines(pPath);
                foreach(string s in positiveWords)
                    Positive.Add(s);
            }
        }
    }
}