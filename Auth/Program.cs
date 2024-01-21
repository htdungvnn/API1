using Auth;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddAuthServices(builder.Configuration);

var app = builder.Build();

app.AddAuthBuider(builder.Environment);

app.MapIdentityApi<IdentityUser>();
app.MapControllers();

app.Run();
