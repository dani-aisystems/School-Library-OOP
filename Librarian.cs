using System;
using System.Collections.Generic;

public class Librarian : Person
{
    private int nextLibraryCardNumber = 1;

    public Librarian(string firstName, string lastName)
        : base(firstName, lastName, 0)
    {
    }

    public void AddBook(List<Book> books, Book book)
    {
        books.Add(book);
    }

    public Reader RegisterReader(List<Reader> readers, string firstName, string lastName)
    {
        int cardNumber = CreateLibraryCard();
        Reader reader = new Reader(firstName, lastName, cardNumber);
        readers.Add(reader);

        Console.WriteLine($"Регистриран читател: {firstName} {lastName}, карта №{cardNumber}");
        return reader;
    }

    public int CreateLibraryCard()
    {
        int cardNumber = nextLibraryCardNumber;
        nextLibraryCardNumber++;
        return cardNumber;
    }
}
