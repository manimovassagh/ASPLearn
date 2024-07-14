using ASPLearn;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGamingEndpoints();

app.Run();
