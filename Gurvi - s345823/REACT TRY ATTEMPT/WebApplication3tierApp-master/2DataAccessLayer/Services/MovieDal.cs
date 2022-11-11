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
    public class MovieDal : IMovieDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public MovieDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<MovieModel> GetAll()
        {
            var result = _db.Movies.ToList();

            var returnObject = new List<MovieModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToMovieModel());
            }

            return returnObject;
        }

        public MovieModel? GetById(int MovieId)
        {
            var result = _db.Movies.SingleOrDefault(x => x.MovieId == MovieId);
            return result?.ToMovieModel();
        }


        public int CreateMovie(MovieModel Movie)
        {
            var newMovie = Movie.ToMovie();
            _db.Movies.Add(newMovie);
            _db.SaveChanges();
            return newMovie.MovieId;
        }


        public void UpdateMovie(MovieModel Movie)
        {
            var existingMovie = _db.Movies
                .SingleOrDefault(x => x.MovieId == Movie.MovieId);

            if (existingMovie == null)
            {
                throw new ApplicationException($"Movie {Movie.MovieId} does not exist.");
            }
            Movie.ToMovie(existingMovie);

            _db.Update(existingMovie);
            _db.SaveChanges();
        }

        public void DeleteMovie(int MovieId)
        {
            var efModel = _db.Movies.Find(MovieId);
            _db.Movies.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
