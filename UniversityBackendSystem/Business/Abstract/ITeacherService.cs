using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<Teacher> GetById(int id);
        IDataResult<List<Teacher>> GetList();
        IResult Add(Teacher teacher);
        IResult Delete(Teacher teacher);
        IResult Update(Teacher teacher);
    }
}
