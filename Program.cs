namespace Csharp_projects.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("B001", "Atomic habits", "James Clear", 5);
        Console.WriteLine($"Book created: {book.Title} by {book.Author}, {book.AvailableCopies} copies available.");
    }
}