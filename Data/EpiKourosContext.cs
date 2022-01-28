using Microsoft.EntityFrameworkCore;

namespace MedicalDashboard.Data;

public class EpiKourosContext : DbContext
{
    public EpiKourosContext(DbContextOptions<EpiKourosContext> options)
        : base(options)
    {
    }

    public DbSet<Patient> Beds { get; set; }
    public DbSet<Sensor> Sensors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>().ToTable("beds");
        modelBuilder.Entity<Patient>().HasKey(m => m.Id);
        modelBuilder.Entity<Patient>().Property(m => m.Id).HasColumnName("id");
        modelBuilder.Entity<Patient>().Property(b => b.RoomId).HasColumnName("ROOM_ID");
        modelBuilder.Entity<Patient>().Property(b => b.RoomName).HasColumnName("ROOM_NAME");
        modelBuilder.Entity<Patient>().Property(b => b.BedId).HasColumnName("BED_ID");
        modelBuilder.Entity<Patient>().Property(b => b.PatName).HasColumnName("PAT_NAME");
        modelBuilder.Entity<Patient>().Property(b => b.Sex).HasColumnName("PAT_SEX");
        modelBuilder.Entity<Patient>().Property(b => b.InDate).HasColumnName("ADM_IN_DATETIME");

        modelBuilder.Entity<Sensor>().ToTable("vdevslog");
        modelBuilder.Entity<Sensor>().HasKey(m => m.Id);
        modelBuilder.Entity<Patient>().Property(m => m.Id).HasColumnName("id");
        modelBuilder.Entity<Sensor>().Property(b => b.RoomId).HasColumnName("room");
        modelBuilder.Entity<Sensor>().Property(b => b.BedId).HasColumnName("bed");
        modelBuilder.Entity<Sensor>().Property(b => b.InDate).HasColumnName("Inserted");
        modelBuilder.Entity<Sensor>().Property(b => b.BPM).HasColumnName("bpm");
        modelBuilder.Entity<Sensor>().Property(b => b.SPO2).HasColumnName("spo2");
        modelBuilder.Entity<Sensor>().Property(b => b.PIPI).HasColumnName("pipi");
    }
}
