using Microsoft.AspNetCore.Builder;
using Shaired2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Models;

namespace Shaired2.ExtentionMethods
{
    public static class Mapper
    {
        public static PublicherReadDTO ToReadDTO(this Publisher publisher) 
        {
            return new PublicherReadDTO() 
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Description = publisher.Description 
            };
        }


        public static Publisher ToClass(this PublicherReadDTO publisher)
        {
            return new Publisher()
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Description = publisher.Description,
                books = new List<Book>()
               
            };
        }
    }
}
