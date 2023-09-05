var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Rupert's Drop Pattern Demonstration in C#");

app.Run();
