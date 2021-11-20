using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concretee.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretee.EntityFramework
{
    public class EfStudentDal:EfEntityRepositoryBase<Student,UniversityContext>,IStudentDal
    {
    }
}
