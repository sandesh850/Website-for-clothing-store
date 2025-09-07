using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelvetVeogue.Models
{
    public class Tbl_CompleteOrders
    {
        [Key]
        public int id { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string? category { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string? ItemType { get; set; }

        [Required, Column(TypeName = "money")]
        public double? price { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string? sizes { get; set; }

        [Required, Column(TypeName = "varchar(30)")]
        public string? color { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string? email { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string? address { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string? contactNo { get; set; }



        //[Required, Column(TypeName = "varchar(70)")]
        //public string? paymentMethod { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? cardDate { get; set; }

        [Required, Column(TypeName = "varbinary")]
        public byte[]? img { get; set; }


        [Column(TypeName = "varchar(100)")]
        public int? CVCNO { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? date { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? CardNo { get; set; }
    }
}
