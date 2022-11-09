using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class MovieDto
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }

    }

    public static class MovieDtoMapExtensions
    {
        public static MovieDto ToMovieDto(this MovieModel src)
        {
            var dst = new MovieDto();
            dst.MovieId = src.MovieId;
            dst.MovieName = src.MovieName;
            return dst;
        }

        public static MovieModel ToMovieModel(this MovieDto src)
        {
            var dst = new MovieModel();
            dst.MovieId = src.MovieId;
            dst.MovieName = src.MovieName;
            return dst;
        }
    }
}
