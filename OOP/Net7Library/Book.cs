namespace Net7Library;
using System.Diagnostics.CodeAnalysis;
public class Book
{
    public Book()
    {

    }
    [SetsRequiredMembers]
    public Book(string isbn, string title)
    {
        Isbn = isbn;
        Title = title;
    }
    public required string? Isbn { get; set;}
    public required string? Title { get; set;}
    public string? Author {get; set;}
    public int Pagecount { get; set; }
}