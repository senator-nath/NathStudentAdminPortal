using Microsoft.AspNetCore.Identity;
using System;

namespace NathStudentAdminPortal.Model
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
        public string Role { get; set; }
        public string ProfileImageUrl { get; set; }

    }
}
