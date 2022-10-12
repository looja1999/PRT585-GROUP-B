using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IBookDal
    {
        // Getters
        BookModel? GetById(int BookId);
        List<BookModel> GetAll();

        // Actions
        int CreateBook(BookModel Book);
        void UpdateBook(BookModel Book);
        void DeleteBook(int BookId);
    }
}
