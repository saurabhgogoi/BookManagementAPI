using BookManagementAPI.Data;
using BookManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementAPI.Repository
{
    public class BookRepo : IBook
    {
        private DataContext _DataContext;
        public BookRepo(DataContext BookDb)
        {
            _DataContext = BookDb;
        }
        public string DeleteBook(int Id)
        {
            string msg = "";
            Book deleteBook = _DataContext.Books.Find(Id);
            if (deleteBook != null)
            {
                _DataContext.Books.Remove(deleteBook);
                _DataContext.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<Book> GetAllBook()
        {
            List<Book> Books = _DataContext.Books.ToList();
            return Books;
        }

        public Book GetBook(int Id)
        {
            Book book = _DataContext.Books.Find(Id);
            return book;
        }

        public string SaveBook(Book book)
        {
            _DataContext.Books.Add(book);
            _DataContext.SaveChanges();
            return "Saved";
        }

        public string UpdateBook(Book book)
        {
            _DataContext.Entry(book).State = EntityState.Modified;
            _DataContext.SaveChanges();
            return "Updated";
        }
    }
}
