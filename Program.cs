var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/json/{name}", (string name) => Results.Json(new { Name = name }));

app.Run();
