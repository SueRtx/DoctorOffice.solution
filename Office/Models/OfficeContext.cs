using Microsoft.EntityFrameworkCore;

namespace Office.Models
{
  public class OfficeContext : DbContext
  {
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<PatientDoctor> PatientDoctor { get; set; }
    public DbSet<Specialty> Specialties { get; set; }

    public OfficeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}