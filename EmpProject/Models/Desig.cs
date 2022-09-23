using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpProject.Models
{
    [Table("EmpDesig")]
    public class Desig
    {
        [Key]
        public int Id { get; set; }
        public int Emp_id { get; set; }



        [StringLength(200)]
        public string Designation { get; set; }

        public bool IsActive { get; set; }
    }
}
