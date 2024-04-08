using Microsoft.EntityFrameworkCore;
using Football.Data.Entities;

namespace Football.Data.DAO;

public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : DbContext(options)
{

    //public DbSet<Patient> Patients { get; set; }
    //public DbSet<DiagnosisRecord> DiagnosisRecords { get; set; }
    public DbSet<PlayerList> PlayerLists { get; set; }
    public DbSet<NegotrationList> NegotrationLists { get; set;}

}