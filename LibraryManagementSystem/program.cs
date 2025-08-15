using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Program
    {
        // Book class
        class Book
        {
            public string Title { get; set; }
            public bool IsCheckedOut { get; set; } = false;
        }

        static void Main(string[] args)
        {
            // Sample book collection
            List<Book> books = new List<Book>
            {
                new Book { Title = "The Great Gatsby" },
                new Book { Title = "1984" },
                new Book { Title = "To Kill a Mockingbird" },
                new Book { Title = "Pride and Prejudice" }
            };

            int borrowedCount = 0;
            const int maxBorrow = 3;

            while (true)
            {
                Console.WriteLine("\nWelcome to the Library Management System!");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Search for a book");
                Console.WriteLine("2. Borrow a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. View all books");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the book title: ");
                        string searchTitle = Console.ReadLine();
                        Book foundBook = books.Find(b => b.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));
                        if (foundBook != null)
                        {
                            Console.WriteLine(foundBook.IsCheckedOut ? "Book is currently checked out." : "Book found! It is available.");
                        }
                        else
                        {
                            Console.WriteLine("Book not found in the collection.");
                        }
                        break;

                    case "2":
                        if (borrowedCount >= maxBorrow)
                        {
                            Console.WriteLine($"You have reached the borrowing limit of {maxBorrow} books.");
                            break;
                        }
                        Console.Write("Enter the book title to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        Book borrowBook = books.Find(b => b.Title.Equals(borrowTitle, StringComparison.OrdinalIgnoreCase));
                        if (borrowBook != null)
                        {
                            if (borrowBook.IsCheckedOut)
                            {
                                Console.WriteLine("Sorry, this book is already checked out.");
                            }
                            else
                            {
                                borrowBook.IsCheckedOut = true;
                                borrowedCount++;
                                Console.WriteLine($"You have borrowed \"{borrowBook.Title}\".");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book not found in the collection.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter the book title to return: ");
                        string returnTitle = Console.ReadLine();
                        Book returnBook = books.Find(b => b.Title.Equals(returnTitle, StringComparison.OrdinalIgnoreCase));
                        if (returnBook != null && returnBook.IsCheckedOut)
                        {
                            returnBook.IsCheckedOut = false;
                            borrowedCount--;
                            Console.WriteLine($"You have returned \"{returnBook.Title}\".");
                        }
                        else
                        {
                            Console.WriteLine("Book was not checked out or not found.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;

                    case "5":
                        Console.WriteLine("\nAll Books:");
                        foreach (var book in books)
                        {
                            string status = book.IsCheckedOut ? "Checked out" : "Available";
                            Console.WriteLine($"- {book.Title} ({status})");
                        }
                        break;


                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-4.");
                        break;
                }
            }
        }
    }
}
