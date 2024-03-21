using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaired2.ExtentionMethods.paging
{
    public static class Paging
    {
        public static List<Publisher> ToFilteredList(List<Publisher> books, string Citty)
        {
            return books.Where(p => p.City == Citty).ToList();
        }

        public static List<Publisher> ToPagedList(this List<Publisher> entities, int pageNumber, int pageSize)
        {
            return entities
                        .Skip((pageNumber - 1) * pageSize)
                        .Take(pageSize).ToList();
        }
    }
}
