using System.Collections.Generic;

namespace NathStudentAdminPortal.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } // Many-to-Many relationship with Student
    }
}

