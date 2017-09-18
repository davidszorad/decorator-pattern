using System;

namespace DecoratorPattern
{
    /*
    This real-world code demonstrates the Decorator pattern in which 'borrowable' functionality 
    is added to existing library items (books and videos).


    The classes and objects participating in this pattern are:

    Component   (LibraryItem)
        defines the interface for objects that can have responsibilities added to them dynamically.

    ConcreteComponent   (Book, Video)
        defines an object to which additional responsibilities can be attached.

    Decorator   (Decorator)
        maintains a reference to a Component object and defines an interface that conforms to Component's interface.

    ConcreteDecorator   (Borrowable)
        adds responsibilities to the component.
    

    OUTPUT:
    Book ------
    Author: Worley
    Title: Inside ASP.NET
    # Copies: 10

    Video -----
    Director: Spielberg
    Title: Jaws
    # Copies: 23
    Playtime: 92


    Making video borrowable:

    Video -----
    Director: Spielberg
    Title: Jaws
    # Copies: 21
    Playtime: 92

    borrower: Customer #1
    borrower: Customer #2
    */

    /// <summary>
    /// Program startup class for Real-World 
    /// Decorator Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}