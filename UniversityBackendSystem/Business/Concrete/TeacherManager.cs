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
    public class TeacherManager : ITeacherService
    {
        private ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }
        public IResult Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
            return new SuccessResult(Messages.TeacherAdded);
        }

        public IResult Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
            return new SuccessResult(Messages.TeacherDeleted);
        }

        public IDataResult<Teacher> GetById(int id)
        {
            return new SuccessDataResult<Teacher>(_teacherDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Teacher>> GetList()
        {
            return new SuccessDataResult<List<Teacher>>(_teacherDal.GetList().ToList());
        }

        public IResult Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
            return new SuccessResult(Messages.TeacherUpdated);
        }
    }
}
