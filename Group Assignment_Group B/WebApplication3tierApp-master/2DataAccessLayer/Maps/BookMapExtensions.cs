using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class BookMapExtensions
    {
        public static BookModel ToBookModel(this Book src)
        {
            var dst = new BookModel();

            dst.BookId = src.BookId;
            dst.BookName = src.BookName;

            return dst;
        }

        public static Book ToBook(this BookModel src, Book dst = null)
        {
            if (dst == null)
            {
                dst = new Book();
            }

            dst.BookId = src.BookId;
            dst.BookName = src.BookName;

            return dst;
        }
    }
}
