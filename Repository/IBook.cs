using BookManagementAPI.Models;

namespace BookManagementAPI.Repository
{
    public interface IBook
    {
        public string SaveBook(Book book);
        public string UpdateBook(Book book);
        public string DeleteBook(int Id);
        public Book GetBook(int Id);
        public List<Book> GetAllBook();
    }
}
