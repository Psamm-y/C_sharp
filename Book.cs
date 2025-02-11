namespace Csharp_projects.Tasks;

public class Book
{
    private string bookId;
    private string title;
    private string author;
    private int availableCopies;

    public Book(string bookId, string title, string author, int availableCopies)
    {
        this.bookId = bookId;
        this.title = title;
        this.author = author;
        this.availableCopies = availableCopies;
    }

    public String BookId
    {
        get => bookId;
        set => bookId = value;
    }
    
}
