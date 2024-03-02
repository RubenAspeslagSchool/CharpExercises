using Microsoft.AspNetCore.Mvc;
using MinimalAPI.Routes;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

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



RouteGroupBuilder studentsGroup = app.MapGroup("/students")
                .WithTags("Students");

StudentRoutes studentRoutes = new StudentRoutes();
studentRoutes.AddRoutes(studentsGroup);

app.Run();

