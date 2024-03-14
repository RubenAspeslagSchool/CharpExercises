using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Models;
using Shaired2.DTOs;

namespace Shaired2.ExtentionMethods.Maping
{
    public static class BookMaper
    {
        public static BoookReadDTO ToReadDTO(this Book book)
        {
            return new BoookReadDTO()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Category = book.Category,
            };
        }

        public static Book ToClass(this BoookReadDTO book) {
            return new Book()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Category = book.Category,
            };
        }
    }
}
