using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmpProject.Models
{
    [Table("EmpInfo")]
    public class Info
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string? Name { get; set; }

        [StringLength(200)]
        public string? NameBn { get; set; }

        [StringLength(200)]
        public string? FathersName { get; set; }

        [StringLength(200)]
        public string? FathersNameBn { get; set; }

        [StringLength(200)]
        public string? MothersName { get; set; }

        [StringLength(200)]
        public string? MothersNameBn { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [StringLength(200)]
        public string? Gender { get; set; }

        [StringLength(200)]
        public string? DetectionSpot { get; set; }
        public int? NidNo { get; set; }
        public int? BirthCertifcateNo { get; set; }
        public int? DrivingLicenseNo { get; set; }

        [StringLength(200)]
        public string? PassportNo { get; set; }

        [StringLength(200)]
        public string? TinNo { get; set; }

        [StringLength(200)]
        public string? CarNo { get; set; }

        [StringLength(200)]
        public string? PresentDistrict { get; set; }

        [StringLength(200)]
        public string? PermanentDistrict { get; set; }

        [StringLength(200)]
        public string? Resident { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Height { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Weight { get; set; }

        [StringLength(200)]
        public string? BloodGroup { get; set; }

        [StringLength(200)]
        public string? Language { get; set; }

        [StringLength(200)]
        public string? PersonalContact { get; set; }

        [StringLength(200)]
        public string? EmergencyContact { get; set; }









    }
}
