using Microsoft.AspNetCore.Identity;

namespace NathStudentAdminPortal.Model
{
    public class Teacher : User
    {
        public int? ClassId { get; set; }
        public Class Class { get; set; }
        public string Subject { get; set; }
    }
}
