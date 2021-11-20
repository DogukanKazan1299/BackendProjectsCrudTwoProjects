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
    public class FacultyManager : IFacultyService
    {
        private IFacultyDal _facultyDal;
        public FacultyManager(IFacultyDal facultyDal)
        {
            _facultyDal = facultyDal;
        }
        public IResult Add(Faculty faculty)
        {
            _facultyDal.Add(faculty);
            return new SuccessResult(Messages.FacultyAdded);
        }

        public IResult Delete(Faculty faculty)
        {
            _facultyDal.Delete(faculty);
            return new SuccessResult(Messages.FacultyDeleted);
        }

        public IDataResult<Faculty> GetById(int id)
        {
            return new SuccessDataResult<Faculty>(_facultyDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Faculty>> GetList()
        {
            return new SuccessDataResult<List<Faculty>>(_facultyDal.GetList().ToList());
        }

        public IResult Update(Faculty faculty)
        {
            _facultyDal.Update(faculty);
            return new SuccessResult(Messages.FacultyUpdated);
        }
    }
}
