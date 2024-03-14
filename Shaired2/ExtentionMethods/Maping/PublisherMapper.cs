using Microsoft.AspNetCore.Builder;
using Shaired2.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Models;

namespace Shaired2.ExtentionMethods.Maping
{
    public static class PublisherMapper
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

        public static List<PublicherReadDTO> ToReadDTOs(this List<Publisher> publishers)
        {
            List<PublicherReadDTO> list = new List<PublicherReadDTO>();
            publishers.ForEach(publisher =>
            {
                list.Add(publisher.ToReadDTO());
            });
            return list;
        }


        public static List<Publisher> ToClasses(this List<PublicherReadDTO> publishers)
        {
            List<Publisher> list = new List<Publisher>();
            publishers.ForEach(publisher =>
            {
                list.Add(publisher.ToClass());
            });
            return list;
        }
    }
}
