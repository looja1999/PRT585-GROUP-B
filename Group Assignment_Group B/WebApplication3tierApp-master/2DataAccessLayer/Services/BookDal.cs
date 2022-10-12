using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class BookDal : IBookDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public BookDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<BookModel> GetAll()
        {
            var result = _db.Books.ToList();

            var returnObject = new List<BookModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToBookModel());
            }

            return returnObject;
        }

        public BookModel? GetById(int BookId)
        {
            var result = _db.Books.SingleOrDefault(x => x.BookId == BookId);
            return result?.ToBookModel();
        }


        public int CreateBook(BookModel Book)
        {
            var newBook = Book.ToBook();
            _db.Books.Add(newBook);
            _db.SaveChanges();
            return newBook.BookId;
        }


        public void UpdateBook(BookModel Book)
        {
            var existingBook = _db.Books
                .SingleOrDefault(x => x.BookId == Book.BookId);

            if (existingBook == null)
            {
                throw new ApplicationException($"Book {Book.BookId} does not exist.");
            }
            Book.ToBook(existingBook);

            _db.Update(existingBook);
            _db.SaveChanges();
        }

        public void DeleteBook(int BookId)
        {
            var efModel = _db.Books.Find(BookId);
            _db.Books.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
