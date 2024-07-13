var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/json/{name}", (string name) => Results.Json(new { Namer = name }));
app.MapGet("/", () => Results.Json(new { Namer = "App is healthy and running" }));

app.Run();
