using System;
using System.Collections.Generic;

public class Reader : Person
{
    private List<Book> borrowedBooks = new List<Book>();

    public Reader(string firstName, string lastName, int libraryCardNumber)
        : base(firstName, lastName, libraryCardNumber)
    {
    }

    public void BorrowBook(List<Book> books, int bookNumber)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].number == bookNumber)
            {
                Book borrowedBook = books[i];
                books.RemoveAt(i);
                borrowedBooks.Add(borrowedBook);
                Console.WriteLine($"{firstName} {lastName} взе книгата \"{borrowedBook.title}\".");
                return;
            }
        }

        Console.WriteLine("Книгата не е налична.");
    }

    public void ReturnBook(List<Book> books, int bookNumber)
    {
        for (int i = 0; i < borrowedBooks.Count; i++)
        {
            if (borrowedBooks[i].number == bookNumber)
            {
                Book returnedBook = borrowedBooks[i];
                borrowedBooks.RemoveAt(i);
                books.Add(returnedBook);
                Console.WriteLine($"{firstName} {lastName} върна книгата \"{returnedBook.title}\".");
                return;
            }
        }

        Console.WriteLine("Тази книга не е взета от читателя.");
    }
}
