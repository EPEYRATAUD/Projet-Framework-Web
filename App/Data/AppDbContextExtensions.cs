using App.Models;

namespace App.Data;
public static class AppDbContextExtensions
{
    public static void Seed(this AppDbContext dbContext)
    {
        if (!dbContext.ResultItem.Any())
        {

            var resultItems = new List<ResultItem>()
            {
                new ResultItem()
                {
                    Id = 1,
                    DriverName = "Jean Louis",
                    Rank = 1
                },
                new ResultItem()
                {
                    Id = 2,
                    DriverName = "Jean Claude",
                    Rank = 2
                },
                new ResultItem()
                {
                    Id = 3,
                    DriverName = "Jean Jean",
                    Rank = 3
                }
            };

            dbContext.ResultItem.AddRange(resultItems);
            dbContext.SaveChanges();
        }
    }
}