using API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAppServices(builder.Configuration);

var app = builder.Build();

app.AddAppBuider(builder.Environment);

app.MapControllers();

app.Run();
