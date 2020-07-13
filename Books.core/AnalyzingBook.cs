using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.core
{
    public class AnalyzingBook : IAnalyzing
    {
        public HashSet<string> AllNegativeWords {get;set;}
        public HashSet<string> AllPositiveWords {get;set;}
        public long BookWordsCount {get;set;}
        public long BookNegetiveWordsCount {get;set;}
        public long BookPositiveWordsCount {get;set;}
        public double PToNPercent {get;set;}

        public AnalyzingBook(Book book , PNWords pn)
        {
            this.BookWordsCount = book.Content.Length;
            this.AllNegativeWords = pn.Negetive;
            this.AllPositiveWords = pn.Positive;
        }
        public async Task CountBookPNWords(Book book)
        {
            await Task.Run(()=>{
                foreach(string word in book.Content)
                {
                    if(this.AllNegativeWords.Contains(word))
                        this.BookNegetiveWordsCount += 1;
                    if(this.AllPositiveWords.Contains(word))
                        this.BookPositiveWordsCount += 1;
                };
            });
        }
        public DataItem[] Chart;
        public async Task EachTenTousond(Book book)
        {
            int loop = (int)(BookWordsCount/10000);
            this.Chart = new DataItem[loop];
            await Task.Run(()=>{
                for(int i=0 ; i<loop ; i++)
                {
                    double p = 0;
                    double n = 0;
                    for(int j=0 ; j<10000 ; j++)
                    {
                        if(this.AllNegativeWords.Contains(book.Content[(i*10000)+j+1]))
                            n += 1;
                        if(this.AllPositiveWords.Contains(book.Content[(i*10000)+j+1]))
                            p += 1;
                    }
                    Chart[i] = new DataItem{
                        PToN = Decimal.Round((decimal)(p/n),4),
                        Words = (i+1)*10000
                    };
                };
            });
        }
    }
}