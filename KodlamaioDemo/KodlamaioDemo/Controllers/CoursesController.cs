using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodlamaioDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    private ICourseManager _courseManager;

    public CoursesController(ICourseManager courseManager)
    {
        _courseManager = courseManager;
    }

    [HttpGet("getall")]
    public IActionResult GetAllCourse()
    {
        try
        {
            var courses = _courseManager.GetAll();
            return Ok(courses);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpGet("GetById")]
    public IActionResult GetOneCourse(int id)
    {
        try
        {
            var course = _courseManager.GetById(id);
            if (course is null)
                return NotFound(); //404

            return Ok(course);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpGet("GetByInstructorId")]
    public IActionResult GetByInstructor(int instructorId)
    {
        try
        {
            var instructor = _courseManager.GetByInstructorId(instructorId);
            if (instructor is null)
                return NotFound(); //404

            return Ok(instructor);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpGet("GetByCategory")]
    public IActionResult GetByCategory(string category)
    {
        try
        {
            var instructors = _courseManager.GetByCategory(category);
            if (instructors is null)
                return NotFound(); //404

            return Ok(instructors);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpPost]
    public IActionResult CreateOneCourse([FromBody] Course course)
    {
        try
        {
            if (course is null)
                return BadRequest(); //400

            _courseManager.Add(course);

            return StatusCode(201, course);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("Update")]
    public IActionResult UpdateOneCourse([FromBody] Course course)
    {
        try
        {
            if (course is null)
                return BadRequest(); //400

            _courseManager.Update(course);

            return Ok(course);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("Delete")]
    public IActionResult DeleteOneCourse([FromRoute] int id, [FromBody] Course course)
    {
        try
        {
            var courseDelete = _courseManager.GetById(id);

            if (course is null)
                return NotFound(); //400

            _courseManager.Delete(course);

            return Ok(course);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }



}
