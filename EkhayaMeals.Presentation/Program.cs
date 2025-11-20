using EkhayaMeals.Application.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


{ 
    builder.Services.AddControllers();

    // scoped services 
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
}
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();