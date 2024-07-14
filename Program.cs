using ASPLearn;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//import list of games from Gaming.cs class

 app.MapGamingEndpoints();

app.Run();
