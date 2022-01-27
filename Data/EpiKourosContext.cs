using Microsoft.EntityFrameworkCore;

namespace MedicalDashboard.Data;

public class EpiKourosContext : DbContext
{
    public EpiKourosContext(DbContextOptions<EpiKourosContext> options)
        : base(options)
    {
    }

    public DbSet<Bed> Beds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bed>().ToTable("beds");

        modelBuilder.Entity<Bed>().HasKey(m => m.Id);
        modelBuilder.Entity<Bed>().Property(b => b.RoomName).HasColumnName("ROOM_NAME");
        modelBuilder.Entity<Bed>().Property(b => b.BedId).HasColumnName("BED_ID");
        modelBuilder.Entity<Bed>().Property(b => b.PatName).HasColumnName("PAT_NAME");
        modelBuilder.Entity<Bed>().Property(b => b.Sex).HasColumnName("PAT_SEX");
    }
}
