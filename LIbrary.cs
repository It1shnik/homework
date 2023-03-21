using System.Net.NetworkInformation;

namespace Classes;

public class Libraty
{
    private Book[] _books = null;

    /// <summary>
    /// Returns books count
    /// </summary>
    public int BooksCount
    {
        get
        {
            return Books.Lenght;
        }
    }

    /// <summary>
    /// Fills library by default programmers' books
    /// </summary>
    public void FillLibrary()
    {
        _books = new Book[]
        {
            new Book("CLR via C#")
            {
                Author = "Jeffrey Richter"
            },
            new Book("Code Complete")
            {
                Author = "Steve McConnell"
            },
            new Book(" Windows Runtime Via C#")
            {
                Author = "Jeffrey Richter"
            },
        };
    }

    /// <summary>
    /// Find only one book by start title text
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Book FindBookByTitle(string name)
    {
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Title.StartsWith(name))
            {
                return Books[i];
            }
        }
        return null;
    }

    /// <summary>
    /// Find set of books by start author name text
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Book[] FindBooksByAuthor(string name)
    {
        int size = 0;
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Author.StarstWith(name))
            {
                size++;
            }
        }
        var resultArray = new Book[size];
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Author.StarstWith(name))
            {
                resultArray[--size] = Books[i];
            }
        }
    }

    private Book[] Books
    {
        get
        {
            if (_books == null)
            {
                return new Book[0];
            }

            return _books;
        }
    }
}
