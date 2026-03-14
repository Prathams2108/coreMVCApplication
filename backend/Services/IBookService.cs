using System;
using backend.Models;
namespace backend.Services
{
    public interface IBookService
    {
        // Define methods for book management, e.g., listing, adding, updating, deleting books
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book> GetBookByISBNAsync(int isbn);
        Task<Book> AddBookAsync(Book book);
        Task<Book> UpdateBookAsync(int isbn, Book updatedBook);
        Task<bool> DeleteBookAsync(int isbn);
        Task<IEnumerable<Book>> GetBooksByGenreAsync(string genre);
        Task<IEnumerable<Book>> GetBooksByAuthorAsync(string author);
        Task<IEnumerable<Book>> GetAvailableBooksAsync();
    }
}