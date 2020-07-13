using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Books.core
{
    public class BookSearch : ISearching
    {
        [Required]
        public string WordToSearch {get;set;}
        public string SearshPath {get;set;}
        public Book FoundBook = new Book("");
        public BookSearch()
        {
            this.SearshPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "books");
        }
        public void SearchBookName(string wordToSearch)
        {
            var allFiles =Directory.EnumerateFiles(SearshPath);
            foreach(string f in allFiles)
            {
                int startIndex = f.LastIndexOf(@"\");
                int lastIndex = f.IndexOf(".txt");
                string bookName = f.Substring(startIndex+1,lastIndex-startIndex-1);
                
                if(bookName.Contains(wordToSearch.ToLower()))
                    this.FoundBook = new Book(bookName);
            }
        }
        public string ShowContent()
        {
            string result = "";
            if(this.FoundBook.BookName != "")
            {
                for(int i=0 ; i<=50 ; i++)
                    result += this.FoundBook.Content[i] + " " ;
            }
            return result+" ...To be continued";
        }
    }
}
