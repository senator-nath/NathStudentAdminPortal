using System.Collections.Generic;

namespace NathStudentAdminPortal.Model
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<LGA> LGAs { get; set; } = new List<LGA>();
    }
}
