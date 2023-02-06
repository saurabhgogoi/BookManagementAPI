using BookManagementAPI.Repository;
using BookManagementAPI.Models;

namespace BookManagementAPI.Services
{
    public class BookService
    {
        public IBook _BookRepository;

        public BookService(IBook bookRepository)
        {
            _BookRepository = bookRepository;
        }

        public string SaveBook(Book book)
        {
            return _BookRepository.SaveBook(book);
        }

        public string DeleteBook(int id)
        {
            return _BookRepository.DeleteBook(id);
        }

        public string UpdateBook(Book book)
        {
            return _BookRepository.UpdateBook(book);
        }

        public Book GetBook(int id)
        {
            return _BookRepository.GetBook(id);
        }

        public List<Book> GetAllBook()
        {
            return _BookRepository.GetAllBook();
        }
    }
}

