using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISectionService
    {
        IDataResult<Section> GetById(int id);
        IDataResult<List<Section>> GetList();
        IResult Add(Section section);
        IResult Delete(Section section);
        IResult Update(Section section);
    }
}
