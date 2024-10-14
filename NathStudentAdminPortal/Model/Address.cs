using System.Data;

namespace NathStudentAdminPortal.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }

    }
}
