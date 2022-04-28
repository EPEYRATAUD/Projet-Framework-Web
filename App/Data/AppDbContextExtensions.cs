using App.Models;

namespace App.Data;
public static class AppDbContextExtensions
{
    public static void Seed(this AppDbContext dbContext)
    {
        if (!dbContext.ResultArrays.Any())
        {

            var ResultArrays = new List<ResultArray>()
            {
                new ResultArray()
                {
                    RaceID = 1,
                    DriverID = "Jean Louis",
                    Rankk = 1
                },
                new ResultArray()
                {
                    RaceID = 2,
                    DriverID = "Jean Claude",
                    Rankk = 2
                },
                new ResultArray()
                {
                    RaceID = 3,
                    DriverID = "Jean Jean",
                    Rankk = 3
                }
            };

            dbContext.ResultArrays.AddRange(ResultArrays);
            dbContext.SaveChanges();
        }
    }
}