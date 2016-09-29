using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.Model
{
    public class Student
    {
        public Guid StudentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First name cannot be empty.")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name cannot be empty.")]
        public string LastName { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

    }
}
