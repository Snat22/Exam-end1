namespace Practicue;

public interface ILibrary
{
    public void Addbook(Book book);

    public Book DisplayBook();

    public void UpdateBook (int id);

    public void DeleteBook(int id);

    public Book SearchByTitle(string title );

    public Book SearchByAuthor(string author);
}
