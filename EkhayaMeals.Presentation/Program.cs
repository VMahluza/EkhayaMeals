using EkhayaMeals.Modules.Authentication.Application;
using EkhayaMeals.Modules.Authentication.Infrastructure;

///<summary>
/// Configure the services for the application.
///</summary>
var builder = WebApplication.CreateBuilder(args);
{ 
    builder.Services.AddControllers();
    builder.Services.AddAuthenticationApplication();
    builder.Services.AddAuthenticationInfrastructure(builder.Configuration);
    builder.Services.AddOpenApi();
}

///<summary>
/// Configure the HTTP request pipeline.
///</summary>
var app = builder.Build();
{ 
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
    }
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
