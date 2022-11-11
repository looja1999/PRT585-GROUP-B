

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieDal _MovieDal;
        //private readonly IMovieBalService _MovieBalService;
        public MovieService(IMovieDal MovieDal
        //ILoggingService loggingService,
        //IMovieDal MovieDal,
        //IAuditDal auditDal
        // IMovieBalanceService balsvc
        )
        {
            _MovieDal = MovieDal;
            // _MovieBalService = balsvc;
        }

        public async Task<MovieModel?> GetById(int MovieId)
        {
            return _MovieDal.GetById(MovieId);
        }

        public async Task<List<MovieModel>> GetAll()
        {
            return _MovieDal.GetAll();
        }

        public async Task<int> CreateMovie(MovieModel Movie)
        {
            //write validations here
            var newMovieId = _MovieDal.CreateMovie(Movie);
            return newMovieId;
        }

        public async Task UpdateMovie(MovieModel Movie)
        {
            //write validations here 
            _MovieDal.UpdateMovie(Movie);
        }

        public async Task DeleteMovie(int MovieId)
        {
            try
            {
                //if(balservice.getBal(MovieId) = 0)
                _MovieDal.DeleteMovie(MovieId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Movie Id:{MovieId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
