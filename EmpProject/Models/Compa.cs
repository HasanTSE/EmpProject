using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpProject.Models
{
    [Table("EmpCompany")]
    public class Compa
    {
        [Key]
        public int Id { get; set; }
        public int Emp_id { get; set; }



        [StringLength(200)]
        public string Company { get; set; }

        public bool IsActive { get; set; }

    }
}
