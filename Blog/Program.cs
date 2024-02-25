var builder = WebApplication.CreateBuilder(args);

builder.ServiceConfigPlugin();

var app = builder.Build();

app.AppConfigPlugin();

app.Run();
