using Microsoft.EntityFrameworkCore;


namespace MachineControlViewer.Server.Models
{
    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Module> Modules { get; set; }
    }

    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Platform Platform { get; set; }
        public int PlatformId { get; set; }
    }

    public class MeasurementType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Measurement
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }

        public Module Module { get; set; }

        public MeasurementType MeasurementType { get; set; }
        public double Value { get; set; }
    }



    public class DataPointsDbContext : DbContext
    {
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<MeasurementType> MeasurementTypes { get; set; }
        public DbSet<Measurement> Measurements { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=DataPoints;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


    }
}
