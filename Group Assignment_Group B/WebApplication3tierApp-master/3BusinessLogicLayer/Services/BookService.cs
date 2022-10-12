

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class BookService : IBookService
    {
        private readonly IBookDal _BookDal;
        //private readonly IBookBalService _BookBalService;
        public BookService(IBookDal BookDal
        //ILoggingService loggingService,
        //IBookDal BookDal,
        //IAuditDal auditDal
        // IBookBalanceService balsvc
        )
        {
            _BookDal = BookDal;
            // _BookBalService = balsvc;
        }

        public async Task<BookModel?> GetById(int BookId)
        {
            return _BookDal.GetById(BookId);
        }

        public async Task<List<BookModel>> GetAll()
        {
            return _BookDal.GetAll();
        }

        public async Task<int> CreateBook(BookModel Book)
        {
            //write validations here
            var newBookId = _BookDal.CreateBook(Book);
            return newBookId;
        }

        public async Task UpdateBook(BookModel Book)
        {
            //write validations here 
            _BookDal.UpdateBook(Book);
        }

        public async Task DeleteBook(int BookId)
        {
            try
            {
                //if(balservice.getBal(MovieId) = 0)
                _BookDal.DeleteBook(BookId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Movie Id:{BookId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
