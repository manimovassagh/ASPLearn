var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var res = new { Namer = "Mani" };

app.MapGet("/json/{name}", (string name) => Results.Json(res));
app.MapGet("/", () => Results.Json(new { Namer = "App is healthy and running" }));

app.Run();
