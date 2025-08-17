using System.ComponentModel.DataAnnotations;

namespace VelvetVeogue.Models
{
    public class TblContactUS
    {
        [Key]
        public int id {  get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string message {  get; set; } = string.Empty;
    }
}
