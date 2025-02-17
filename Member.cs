using System;
namespace Csharp_projects.Tasks;

public class Member
{
    private string memberId;
    private string name;
    private Book borrowedBook;

    public Member(string memberId, string name)
    {
        this.memberId = memberId;
        this.name = name;
        this.borrowedBook = null;
    }

    public string MemberId { get; set; }

    public string Name { get; set; }

    public Book BorrowedBook { get; set; }

    public void BorrowBook(Book book)
    {
        if (borrowedBook == null && book.AvailableCopies>0)
        {
            borrowedBook = book;
            book.BorrowBook();
            Console.WriteLine($"{name} borrowed Book '{book.Title}'.");
        }
        else
        {
            Console.WriteLine("Oops.. cannot borrow book");
        }
    }

    public void ReturnBook(Book book)
    {
        if (borrowedBook != null)
        {
            borrowedBook.ReturnBook();
            Console.WriteLine($"{name} returned Book '{book.Title}'.");
            borrowedBook = null;
        }
        else
        {
            Console.WriteLine($"{name} has no book to return");
        }
    }

    
}