using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelvetVeogue.Models
{
    public class Tbl_Inquiries
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        public string subject { get; set; } = string.Empty;

        
        [Column(TypeName = "text")]
        public string? Message { get; set; } 

        [Column(TypeName = "text")]
        public string? Name { get; set; }

        [Column(TypeName = "text")]
        public string? ContactNo { get; set; } 
    }
}
