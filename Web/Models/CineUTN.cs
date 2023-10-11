namespace Web.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


public class CineUTN : DbContext
{
    public CineUTN(DbContextOptions<CineUTN> options) : base(options)
    {

    }
    public DbSet<CineUTN> CineUTNs { get; set; }
}


