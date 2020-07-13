namespace Books.core
{
    public interface IBook
    {
        string BookName {get;set;}
        string FilePath {get;set;}
        string[] Content {get;set;}
        string PicPath {get;set;}
    }
}