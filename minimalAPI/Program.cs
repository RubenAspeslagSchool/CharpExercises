
namespace minimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            WebApplication app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            //var summaries = new[]
            //{
            //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            //};

            //app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            //{
            //    var forecast = Enumerable.Range(1, 5).Select(index =>
            //        new WeatherForecast
            //        {
            //            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //            TemperatureC = Random.Shared.Next(-20, 55),
            //            Summary = summaries[Random.Shared.Next(summaries.Length)]
            //        })
            //        .ToArray();
            //    return forecast;
            //})
            //.WithName("GetWeatherForecast")
            //.WithOpenApi();


            RouteGroupBuilder studentsGroup = app.MapGroup("/students")
                .WithTags("Students");

            studentsGroup.MapGet("", () =>
            {
     
                return Results.Ok(new StudentRepository().GetAllStudents);
            });


            studentsGroup.MapGet("/{id:int}", (int id) => 
            {
                Student student = new StudentRepository().GetStudentById(id);
                return student is Student foundStudent
                    ? Results.Ok(foundStudent)
                    : Results.NotFound($"student with ID {id} not fount");


               
                //if (foundStudent is Student)
                //{
                //    return Results.Ok(foundStudent);
                //} else
                //{
                //    return Results.NotFound($"student with ID {id} not fount");
                //}
            });

            app.Run();
        }
    }
}
