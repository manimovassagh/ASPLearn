using ASPLearn.Entities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var res = new { Namer = "Mani" };


List<Game> games = new List<Game>
{
    new Game { Name = "Game 1", Price = 10 },
    new Game { Name = "Game 2", Price = 20 },
    new Game { Name = "Game 3", Price = 30 }
};
app.MapGet("/json/{name}", (string name) => Results.Json(res));
app.MapGet("/", () => games);

app.Run();
