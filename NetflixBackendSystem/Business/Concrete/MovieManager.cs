using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult(Messages.MovieAdded);
        }

        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(Messages.MovieDeleted);
        }

        public IDataResult<Movie> GetById(int id)
        {
            return new SuccessDataResult<Movie>(_movieDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Movie>> GetList()
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetList().ToList());
        }

        public IDataResult<List<Movie>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetList(x => x.CategoryId == categoryId).ToList());
        }

        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult(Messages.MovieUpdated);
        }
    }
}
