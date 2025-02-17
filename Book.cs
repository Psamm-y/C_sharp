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

    public void BorrowBook()
    {
        if (availableCopies > 0)
        {
            availableCopies--;
            Console.WriteLine($"Book '{title}' borrowed successfully. Available copies: {availableCopies}");
        }
        else
        {
            Console.WriteLine($"Book '{title}' is out of stock");
        }
    }

    public void ReturnBook()
    {
        availableCopies++;
        Console.WriteLine($"Book '{title}' has been returned. Avaiolable copies : {availableCopies}");
    }

}
