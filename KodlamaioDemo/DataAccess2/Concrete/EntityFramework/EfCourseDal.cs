using Core.DataAccess.EntityFramework;
using DataAccess2.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess2.Concrete.EntityFramework;

public class EfCourseDal : EfEntityRepositoryBase<Course, CourseKodlamaioContext>, ICourseDal
{

}
