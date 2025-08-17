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

    }
}
