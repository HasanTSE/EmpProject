using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpProject.Models
{
    [Table("EmpDept")]
    public class Dept
    {
        [Key]
        public int Id { get; set; }
        public int Emp_id { get; set; }



        [StringLength(200)]
        public string Department { get; set; }

        public bool IsActive { get; set; }
    }
}
