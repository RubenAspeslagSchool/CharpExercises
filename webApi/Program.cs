using ClassLib.Reposetorys;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Books API version 1",
        Version = "v1",
        Description = "API to manage books"
    });
    c.SwaggerDoc("v2", new OpenApiInfo
    {
        Title = "Books API version 2",
        Version = "v2",
        Description = "API to manage books"
    });
});

builder.Services.AddApiVersioning(o => {
    o.ReportApiVersions = true;
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new ApiVersion(1, 0);
    o.ApiVersionReader = ApiVersionReader.Combine(
                                            new QueryStringApiVersionReader("version"),
                                            new HeaderApiVersionReader("api-version"),
                                            new MediaTypeApiVersionReader("v"));
});
builder.Services.AddVersionedApiExplorer(
    options =>
    {
        // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
        // note: the specified format code will format the version as "'v'major[.minor][-status]"
        options.GroupNameFormat = "'v'VVV";

        // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
        // can also be used to control the format of the API version in route templates
        options.SubstituteApiVersionInUrl = true;
    }
);

// dependency injection
builder.Services.AddScoped<IPublisherReposetory, PublisherReposetory>();

// fluent validation
builder.Services.AddFluentValidationAutoValidation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My books API v1");
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "My books API v2");
    }); ;
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
