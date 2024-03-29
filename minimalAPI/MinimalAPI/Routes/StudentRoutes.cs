﻿using ClassLib.Reposetorys;
using Microsoft.AspNetCore.Mvc;

namespace MinimalAPI.Routes
{
    public static class StudentRoutes
    {
        
       
        public static void AddStudentRoutes(this RouteGroupBuilder studentsGroup)
        {
            StudentRepository studentRepository = new StudentRepository();

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

        }
    }
}
