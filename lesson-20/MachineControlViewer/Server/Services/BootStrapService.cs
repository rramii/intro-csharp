using MachineControlViewer.Server.Models;

namespace MachineControlViewer.Server.Services
{
    public class BootStrapService
    {
        public BootStrapService()
        {

        }

        public void initialize()
        {
            var db = new DataPointsDbContext();
            db.Add(new Platform()
            {
                Name = "CubeSat-3"
            });



            db.Add(new Platform()
            {
                Name = "Tractor-D9"
            });

            var type1 = new MeasurementType() { Name = "Volatge" };
            var type2 = new MeasurementType() { Name = "Current" };
            var type3 = new MeasurementType() { Name = "Temprature" };

            db.MeasurementTypes.Add(type1);
            db.MeasurementTypes.Add(type2);
            db.MeasurementTypes.Add(type3);
            var q = from p in db.Platforms
                    where p.Id == 1
                    select p;

            var platform = q.Single();
            var m1 = new Module() { Name = "Solar-1", Platform = platform };
            var m2 = new Module() { Name = "Solar-2", Platform = platform };
            db.Modules.Add(m1);
            db.Modules.Add(m2);

            var rng = new Random();
            for (int i = 0; i < 100; i++)
            {
                var dp1 = new Measurement()
                {
                    Module = m1,
                    Time = DateTime.Now.AddSeconds(i),
                    MeasurementType = type3,
                    Value = (double)rng.Next(-420, +1400) / 10
                };
                db.Measurements.Add(dp1);
                var dp2 = new Measurement()
                {
                    Module = m2,
                    Time = DateTime.Now.AddSeconds(i),
                    MeasurementType = type2,
                    Value = (double)rng.Next(0, 50) / 10
                };
                db.Measurements.Add(dp2);
            }
            db.SaveChanges();

        }
    }
}
