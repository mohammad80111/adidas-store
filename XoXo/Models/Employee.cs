using System.ComponentModel.DataAnnotations;

namespace XoXo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [Range(19, 50)]
        public int age { get; set; }
    }
}
