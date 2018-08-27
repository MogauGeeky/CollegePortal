using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Business.Dto
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        [Required, MaxLength(60)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required, MaxLength(60)]
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [Required, MaxLength(120), EmailAddress]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
        [Required, MaxLength(13)]
        [DisplayName("Id Number")]
        public string IDNumber { get; set; }
    }
}