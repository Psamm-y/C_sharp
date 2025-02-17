namespace Csharp_projects.Tasks;

public class Program
{
    static void Main()
    {
        Book book = new Book("B001", "Atomic habits", "James Clear", 5);
        Console.WriteLine($"Book created: {book.Title} by {book.Author}, {book.AvailableCopies} copies available.");
        
        //member objects
        Member member1 = new Member("M323", "Psammy");
        Member member2 = new Member("M325", "Bernard");
        
        member1.BorrowBook(book); //Psammy borrows book
        member2.BorrowBook(book); //Bernard borrows book
        member2.BorrowBook(book);//Bernard cannot borrow anymore until he returns the first book
        
        //calling return book method
        member2.ReturnBook(book);
        //member 2 (Bernard) can borrow after here
    }
}