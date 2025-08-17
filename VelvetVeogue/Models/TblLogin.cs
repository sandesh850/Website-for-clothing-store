using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelvetVeogue.Models
{
    public class TblLogin
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)") ]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty ;
    }
}
