using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICourseManager
{
    List<Course> GetAll();
    Course GetById(int id);
    List<Course> GetByInstructorId(int instructorId);
    List<Course> GetByCategory(string category);
    void Add(Course course);
    void Delete(Course course);
    void Update(Course course);
}
