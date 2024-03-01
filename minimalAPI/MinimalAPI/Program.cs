using Microsoft.AspNetCore.Mvc;

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

StudentRepository studentRepository = new StudentRepository();

RouteGroupBuilder studentsGroup = app.MapGroup("/students")
                .WithTags("Students");

studentsGroup.MapGet("/", () =>
{
    return Results.Ok(studentRepository.GetAllStudents());
});


studentsGroup.MapGet("/{id:int}", (int id) =>
{
    Student student = studentRepository.GetStudentById(id);
    return student != null
        ? Results.Ok(student)
        : Results.NotFound($"student with ID {id} not fount");
});

studentsGroup.MapPost("/", (string name, bool succeded) =>
{
     return Results.Ok(studentRepository.AddStudent(name, succeded));
});


studentsGroup.MapPut("/{id:int}", (int id, string name, bool succeded) =>
{
    studentRepository.PutStudent(id, name, succeded);
    return Results.Ok(studentRepository.GetAllStudents());
});

studentsGroup.MapDelete("/{id:int}", (int id) =>
{
    studentRepository.DeleteStudent(id);
    return Results.Ok(studentRepository.GetAllStudents());
});

studentsGroup.MapGet("/random", ([FromQuery] int random) => 
{
    return Results.Ok(studentRepository.GetRandom(random));
});

app.Run();

