using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILessonService
    {
        IDataResult<Lesson> GetById(int id);
        IDataResult<List<Lesson>> GetList();
        IResult Add(Lesson lesson);
        IResult Delete(Lesson lesson);
        IResult Update(Lesson lesson);
    }
}
