using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication10
{

        public class MyContext : DbContext
        {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<WeatherForecast> Weathers { get; set; }

            #region Required
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<WeatherForecast>()
                    .Property(b => b.TemperatureC)
                    .IsRequired();
            }
            #endregion
        }

}
