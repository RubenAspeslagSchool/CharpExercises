using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class PublisherReposetory
    {
        private List<Publisher> _Publishers;
        public PublisherReposetory() 
        {
            _Publishers = new List<Publisher>();
        }

        public List<Publisher> GetPublishers() { return _Publishers; }

        public Publisher GetPublisherstById(int id) { 
            return _Publishers.SingleOrDefault(x => x.Id == id); 
        }

        public List<Book> GetBooksOfPublisher(int id, string? category )
        {
            
            return category is string 
                ? GetPublisherstById(id).books
                    .Where(b => { return b.Category == category; })
                    .ToList()
                : GetPublisherstById(id).books;
        }
    }
}
