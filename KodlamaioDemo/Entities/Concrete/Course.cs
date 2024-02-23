using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Course : IEntity
{
    public int Id { get; set; }
    public string CourseName { get; set; }
    public string Category { get; set; }
    public int InstructorId { get; set; }
    public string Instructor { get; set; }
}
