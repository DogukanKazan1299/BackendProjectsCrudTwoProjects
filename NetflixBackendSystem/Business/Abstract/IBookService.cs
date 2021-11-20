using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<Book> GetById(int id);
        IDataResult<List<Book>> GetList();
        IDataResult<List<Book>> GetListByCategory(int categoryId);
        IResult Add(Book book);
        IResult Delete(Book book);
        IResult Update(Book book);
    }
}
