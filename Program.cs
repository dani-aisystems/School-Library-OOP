using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<Reader>();

        Librarian librarian = new Librarian("Мария", "Иванова");

        librarian.AddBook(books, new Book("Под игото", "Роман", 1, "Иван Вазов"));
        librarian.AddBook(books, new Book("Бай Ганьо", "Сатира", 2, "Алеко Константинов"));
        librarian.AddBook(books, new Book("Немили-недраги", "Повест", 3, "Иван Вазов"));

        Reader firstReader = librarian.RegisterReader(readers, "Иван", "Петров");
        librarian.RegisterReader(readers, "Елена", "Георгиева");

        firstReader.BorrowBook(books, 2);

        Console.WriteLine("\nНалични книги след заемането:");
        foreach (Book book in books)
        {
            Console.WriteLine($"№{book.number} - {book.title}, {book.author}, жанр: {book.genre}");
        }

        firstReader.ReturnBook(books, 2);

        Console.WriteLine("\nНалични книги след връщането:");
        foreach (Book book in books)
        {
            Console.WriteLine($"№{book.number} - {book.title}, {book.author}, жанр: {book.genre}");
        }
    }
}
