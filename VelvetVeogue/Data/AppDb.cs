using Microsoft.EntityFrameworkCore;
using VelvetVeogue.Models;

namespace VelvetVeogue.Data
{
    public class AppDb: DbContext
    {
        
        public AppDb(DbContextOptions<AppDb> options ) : base (options)
        {

        }

        public DbSet<TblLogin> TblLogins { get; set; }

        public DbSet<Tbl_ItemDetails> Tbl_ItemDetails { get; set; }

        public DbSet<TblContactUS> Tbl_ContactUS { get; set; }

        public DbSet<Tbl_Inquiries> Tbl_Inquiries { get; set; }

        public DbSet<Tbl_OrderDetails> Tbl_OrderDetails { get; set; }

        public DbSet<Tbl_CompleteOrders> Tbl_CompleteOrders { get; set; }

    }
}
