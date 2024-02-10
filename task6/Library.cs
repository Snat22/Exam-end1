namespace Practicue;

public class Library : ILibrary
{
    List<Book> _books = new List<Book>();
    public void Addbook(Book book)
    {
        _books.Add(book);
    }


    public Book DisplayBook()
    {
        
    }
    
    public void DeleteBook(int id)
    {
       var deleted = _books.FirstOrDefault(e=> e.Id == id);
       _books.Remove(deleted);
    }

    public Book SearchByAuthor(string author)
    {
        var auth = _books.FirstOrDefault(e=> e.Author == author);
        return auth;
    }

    public Book SearchByTitle(string title)
    {
    return _books.FirstOrDefault(e=> e.Title == title);
        
    }

    public void UpdateBook(int id)
    {
        _books.FirstOrDefault(e=> e.Id == id);
        
        
    }


   
}
