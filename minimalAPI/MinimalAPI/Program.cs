using Microsoft.AspNetCore.Mvc;
using MinimalAPI.Routes;
using ClassLib;

 (WebApplicationBuilder builder,IServiceCollection services, ConfigurationManager conf) = WebApplication.CreateBuilder(args);
string apiPrefix = conf["ApiPrefix"] ?? "/api";
//WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



 app.MapGroup($"{apiPrefix}/students")
                .WithTags("Students")
                .AddStudentRoutes();


app.Run();

