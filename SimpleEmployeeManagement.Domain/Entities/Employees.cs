
using SimpleEmployeeManagement.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace SimpleEmployeeManagement.Domain.Entities
{
    public class Employees
    {
        public int Id { get; set; }
       // [Required(ErrorMessage="Please Enter First Name")]
        [StringLength(10)]
        public string? First_name { get; set; }
		//[Required(ErrorMessage = "Please Enter Last  Name")]
		[StringLength(10)]
        public string? Last_name { get; set;}
        public  string? Email { get; set; }

        public DateTime? RegistrationDate  { get; set; }
        [EnumDataType(typeof(Department),ErrorMessage ="Please Select a Department")]
        public Department Department  { get; set; }

    }
}
