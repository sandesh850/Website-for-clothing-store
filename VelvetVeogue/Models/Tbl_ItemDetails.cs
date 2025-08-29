using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelvetVeogue.Models
{
    public class Tbl_ItemDetails
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int ItemCode { get; set; } = 0;

        [Required]
        [Column(TypeName ="varchar(30)")]
        public string CategoryName { get; set; } = string.Empty;

        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Color {  get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string size { get; set; } = string.Empty;

        [Required]
        public int AvailableQty { get; set; } = 0;

        [Required]
        [Column(TypeName ="money")]
        public double Price { get; set; } = 0;

        [Required]
        public byte[]? img { get; set; }

        [Required,Column(TypeName ="varchar(20)")]
        public string? ItemType { get; set; }



    }
}
