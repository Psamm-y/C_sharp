namespace Csharp_projects.Tasks;

public class Book
{
    private string bookId;
    private string title;
    private string author;
    private int availableCopies;

    //Constructor
    public Book(string bookId, string title, string author, int availableCopies)
    {
        this.bookId = bookId;
        this.title = title;
        this.author = author;
        this.availableCopies = availableCopies;
    }

    //Getters and Setters
    public string BookId
    {
        get => bookId;
        set => bookId = value;
    }
    public string Title
    {
        get => title;
        set => title = value;
    }

    public string Author
    {
        get => author;
        set => author = value;
    }

    public int AvailableCopies
    {
        get => availableCopies;
        set => availableCopies = value;
    }
}
