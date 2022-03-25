using App.Models;

namespace App.Middlewares
{
    public static class MiddlewaresExtensions
    {
        public static IApplicationBuilder UseBasicMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<BasicMiddleware>();
        }
        public static Race SanitizeRaceData(this Race race)
        {
            race.Name.Trim();
            return race;
        }
    }
}