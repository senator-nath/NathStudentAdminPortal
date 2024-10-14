using System.Security.Claims;
using System;
using System.Collections.Generic;

namespace NathStudentAdminPortal.Model
{
    public class Student : User
    {

        public int? ClassId { get; set; }
        public Class Class { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}

