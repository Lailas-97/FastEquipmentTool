using System.ComponentModel.DataAnnotations;

namespace FastEquipmentTool.Models
{
    public enum UserRole { Student, Staff, Faculty }
    public enum EquipmentType { Laptop, Phone, Tablet, Another }

    public class EquipmentRequest
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required, RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone must be 999-999-9999")]
        public string Phone { get; set; } = "";

        [Required]
        public UserRole Role { get; set; }

        [Required]
        public EquipmentType EquipmentType { get; set; }   

        [Required, StringLength(500)]
        public string RequestDetails { get; set; } = "";

        [Range(1, 30)]
        public int DurationDays { get; set; }
    }
}