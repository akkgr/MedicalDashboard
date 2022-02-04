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
        modelBuilder.Entity<Patient>().Property(m => m.Id).HasColumnName("ADM_ID");
        modelBuilder.Entity<Patient>().Property(b => b.Department).HasColumnName("ADM_DEPT");
        modelBuilder.Entity<Patient>().Property(b => b.PatientId).HasColumnName("PAT_ID");
        modelBuilder.Entity<Patient>().Property(b => b.InDate).HasColumnName("ADM_IN_DATETIME").HasColumnType("datetime");
        modelBuilder.Entity<Patient>().Property(b => b.Surname).HasColumnName("PAT_SURNAME");
        modelBuilder.Entity<Patient>().Property(b => b.Firstname).HasColumnName("PAT_FIRSTNAME");
        modelBuilder.Entity<Patient>().Property(b => b.Fathername).HasColumnName("PAT_FATHERNAME");
        modelBuilder.Entity<Patient>().Property(b => b.Birthdate).HasColumnName("PAT_BIRTH_DATE");
        modelBuilder.Entity<Patient>().Property(b => b.Description).HasColumnName("DIAGN_DESC");
        modelBuilder.Entity<Patient>().Property(b => b.Room).HasColumnName("ADM_ROOM_CODE");
        modelBuilder.Entity<Patient>().Property(b => b.Bed).HasColumnName("ADM_BED");

        modelBuilder.Entity<Sensor>().ToTable("vdevslog");
        modelBuilder.Entity<Sensor>().HasKey(m => m.Id);
        modelBuilder.Entity<Sensor>().Property(m => m.Id).HasColumnName("id");
        modelBuilder.Entity<Sensor>().Property(b => b.RoomId).HasColumnName("room");
        modelBuilder.Entity<Sensor>().Property(b => b.BedId).HasColumnName("bed");
        modelBuilder.Entity<Sensor>().Property(b => b.InDate).HasColumnName("updtime");
        modelBuilder.Entity<Sensor>().Property(b => b.BPM).HasColumnName("bpm");
        modelBuilder.Entity<Sensor>().Property(b => b.SPO2).HasColumnName("spo2");
        modelBuilder.Entity<Sensor>().Property(b => b.PIPI).HasColumnName("pipi");
    }
}
