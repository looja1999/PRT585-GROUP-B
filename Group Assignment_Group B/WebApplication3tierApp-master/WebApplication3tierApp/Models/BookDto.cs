using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

    }

    public static class BookDtoMapExtensions
    {
        public static BookDto ToBookDto(this BookModel src)
        {
            var dst = new BookDto();
            dst.BookId = src.BookId;
            dst.BookName = src.BookName;
            return dst;
        }

        public static BookModel ToBookModel(this BookDto src)
        {
            var dst = new BookModel();
            dst.BookId = src.BookId;
            dst.BookName = src.BookName;
            return dst;
        }
    }
}
