using Training_Management.Context;
using Training_Management.Models;

namespace Training_Management.Repository
{
    public class CourseRepository : CourseInterface
    {
        TrainingDbContext __db;

        public CourseRepository(TrainingDbContext db)
        {
            __db = db;
        }
        public Course Create(Course course)
        {
            __db.Courses.Add(course);
            __db.SaveChanges();
            return course;

        }

        public int Delete(int id)
        {
           
                Course obj = GetCourseById(id);
                if (obj != null)
                {
                   __db.Courses.Remove(obj);
                    __db.SaveChanges();
                }
                return 1;
            
        }

        public int Edit(int id, Course course)
        {
            Course obj = GetCourseById(id);
            if (obj != null)
            {
                foreach (Course temp in __db.Courses)
                {
                    if (temp.CourseId == id)
                    {
                        temp.CourseName = course.CourseName;
                        temp.Description = course.Description;
                        temp.Duration = course.Duration;
                       


                    }
                }
                __db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }

        public Course GetCourseById(int id)
        {
            return __db.Courses.FirstOrDefault(x => x.CourseId == id);
        }

        public List<Course> GetCourses()
        {
            return __db.Courses.ToList();
        }
    }
}