using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelvetVeogue.Models
{
    public class Tbl_ItemDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoryCode { get; set; } = 0;

        [Required]
        public string CategoryName { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        [Required]
       
        public string Color {  get; set; } = string.Empty;

        [Required]
        public string size { get; set; } = string.Empty;

        [Required]
        public int AvailableQty { get; set; } = 0;

        [Required]
        [Column(TypeName ="money")]
        public double Price { get; set; } = 0;

    }
}
