using Training_Management.Models;

namespace Training_Management
{
    public interface CourseInterface
    {
        List<Course> GetCourses();
        Course Create(Course course);
        Course GetCourseById(int id);
        int Delete(int id);
        int Edit(int id, Course course);
    }
}
