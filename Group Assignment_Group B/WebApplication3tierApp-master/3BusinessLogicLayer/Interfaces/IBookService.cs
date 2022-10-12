using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IBookService
    {
        Task<BookModel?> GetById(int BookId);
        Task<List<BookModel>> GetAll();

        Task<int> CreateBook(BookModel Book);
        Task UpdateBook(BookModel Book);
        Task DeleteBook(int BookId);
    }
}
