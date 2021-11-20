using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieService
    {
        IDataResult<Movie> GetById(int id);
        IDataResult<List<Movie>> GetList();
        IDataResult<List<Movie>> GetListByCategory(int categoryId);

        IResult Add(Movie movie);
        IResult Delete(Movie movie);
        IResult Update(Movie movie);
    }
}
