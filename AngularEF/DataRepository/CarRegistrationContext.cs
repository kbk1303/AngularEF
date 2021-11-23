using AngularEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/**
 * This Context will migrate the following tables via Entity Framework to a Database called CarRegistrationDB
 * 
 * Table Car - Make and Model of a Car
 * Owner - Owner information
 * Registration - Information of first-reg-day, Current-check-up-date, next-check-up-date, Registration-identifier
 * CheckUp - Holds information about next check-up
 * CarOwner (AutoCreated as 1-n against Owner and n-1 against Car)
 * 
 * Cardinality
 * 1-1: Car -> Registration. Car is principal entity. 
 * 1-n Registration -> CheckUp. Registration is principal entity. Holds a Foreignkey of CheckUp
 * n-m CarOwner -> Car Many to many relation. many cars can owned by many owners. Many owners can own many cars
 * 
 * 
*/

namespace AngularEF.DataRepository
{
    public class CarRegistrationContext : DbContext
    {
        public CarRegistrationContext(DbContextOptions<CarRegistrationContext> options):base(options) {}

        public DbSet<CheckUp> CheckUps { get; set; }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Owner> Owners { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasIndex(e => e.cpr).IsUnique();
            });
        }
        
    }
}
