using System.Collections.Generic;

namespace NathStudentAdminPortal.Model
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
