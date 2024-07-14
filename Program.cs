using ASPLearn.Entities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var res = new { Namer = "Mani" };


List<Game> games =
[
    new Game { Name = "Mani", Price = 10 },
    new Game { Name = "Sahar Game", Price = 20 },
    new Game { Name = "Mehdi is playing", Price = 30 }
];
app.MapGet("/json/{name}", (string name) => Results.Json(res));
app.MapGet("/", () => games);

app.Run();
