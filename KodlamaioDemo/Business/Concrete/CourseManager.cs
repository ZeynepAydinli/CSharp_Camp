using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess2.Abstract;

namespace Business.Concrete;
public class CourseManager : ICourseManager
{
    private ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetList().ToList();
    }

    public List<Course> GetByCategory(string category)
    {
        return _courseDal.GetList(b => b.Category == category).ToList();
    }

    public Course GetById(int id)
    {
        return _courseDal.Get(b => b.Id == id);
    }

    public List<Course> GetByInstructorId(int instructorId)
    {
        return _courseDal.GetList(b => b.InstructorId == instructorId).ToList();
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
