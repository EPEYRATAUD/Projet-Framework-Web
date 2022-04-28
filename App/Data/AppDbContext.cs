using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data;

public class AppDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarCategory> CarCategories { get; set; }
    public DbSet<CarCategoryArray> CarCategoryArrays { get; set; }
    public DbSet<CarOwnersArray> CarOwnersArrays { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<DriverArray> DriverArrays { get; set; }
    public DbSet<OwnedVehiculesArray> OwnedVehiculesArrays { get; set; }
    public DbSet<Race> Races { get; set; }
    public DbSet<RaceCategoryArray> RaceCategoryArrays { get; set; }
    public DbSet<RacesArray> RacesArrays { get; set; }
    public DbSet<ResultArray> ResultArrays { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}