using ASPLearn.Entities;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var res = new { Namer = "Mani" };

//import list of games from Gaming.cs class
List<Game> games = new Gaming().Games;



app.MapGet("/json/{name}", (string name) => Results.Json(res));
app.MapGet("/", () => games);

app.Run();
