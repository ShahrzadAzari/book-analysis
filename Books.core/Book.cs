using System.IO;
using System.Reflection;

namespace Books.core
{
    public class Book : IBook
    {
        public string BookName {get;set;}
        public string FilePath {get;set;}
        public string PicPath {get;set;}
        public string[] Content {get;set;}

        public Book(string name)
        {
            this.BookName = name;
            if(this.BookName != "")
            {
                this.FilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "books\\"+this.BookName+".txt");                
                this.PicPath = @"/Images/"+ this.BookName +".jpg";
                this.Content = File.ReadAllText(this.FilePath).Split();
            }
        }
    }
}