using System.Collections.Generic;

namespace Books.core
{
    public interface IAnalyzing
    {
        HashSet<string> AllNegativeWords {get;set;}
        HashSet<string> AllPositiveWords {get;set;}
        long BookWordsCount {get;set;}
        long BookNegetiveWordsCount {get;set;}
        long BookPositiveWordsCount {get;set;}
    }
}