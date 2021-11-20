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
    public class SectionManager : ISectionService
    {
        private ISectionDal _sectionDal;
        public SectionManager(ISectionDal sectionDal)
        {
            _sectionDal = sectionDal;
        }
        public IResult Add(Section section)
        {
            _sectionDal.Add(section);
            return new SuccessResult(Messages.SectionAdded);
        }

        public IResult Delete(Section section)
        {
            _sectionDal.Delete(section);
            return new SuccessResult(Messages.SectionDeleted);
        }

        public IDataResult<Section> GetById(int id)
        {
            return new SuccessDataResult<Section>(_sectionDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Section>> GetList()
        {
            return new SuccessDataResult<List<Section>>(_sectionDal.GetList().ToList());
        }

        public IResult Update(Section section)
        {
            _sectionDal.Update(section);
            return new SuccessResult(Messages.SectionUpdated);
        }
    }
}
