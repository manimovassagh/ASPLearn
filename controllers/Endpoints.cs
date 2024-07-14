using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ASPLearn.Entities;

namespace ASPLearn
{
    public static class GamingEndpoints
    {
        public static void MapGamingEndpoints(this WebApplication app)
        {
            var res = new { Name = "Mani" };

            app.MapGet("/json/{name}", (string name) => Results.Json(res));
            app.MapGet("/", () => new Gaming().Games);
            app.MapGet("/sahar", () => new Gaming().Games);
        }
    }
}
