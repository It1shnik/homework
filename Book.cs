namespace Classes;

public class Book
{
    Title _title;
    Author _author;

    public string Author
    {
        set
        {
            _author.Name = value;
        }
        get
        {
            return _author.Name;
        }
    }

    public string Title
    {
       get
       {
        return _title.Content
       }
       set
       {
       _title.Content = value;
       }
    }

    public Book(string title)
    {
        InitializeBook();
        _title.Content = title;
    }

    public void Show()
    {
        this._title.Show();
        this._author.Show();
    }

    private void InitializeBook()
    {
        this._title = new Title();
        this._author = new Author();
    }
}
