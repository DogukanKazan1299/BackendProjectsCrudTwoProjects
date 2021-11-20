using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFacultyService
    {
        IDataResult<Faculty> GetById(int id);
        IDataResult<List<Faculty>> GetList();
        IResult Add(Faculty faculty);
        IResult Delete(Faculty faculty);
        IResult Update(Faculty faculty);
    }
}
