using ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Reposetorys
{
    public class PublisherReposetory : IPublisherReposetory
    {
        private List<Publisher> _Publishers;
        public PublisherReposetory()
        {
            _Publishers = new List<Publisher>()
            {
                new Publisher() 
                {
                 Id = 0,
                 Name = "Ruben", 
                 City = "Brugge", 
                 books = new List<Book>() 
                    { 
                     new Book() { 
                         Id = 1, 
                         Title = "The unsolvable .net error"
                     },
                     new Book() {
                         Id = 2,
                         Title = "The horor of python"
                     },
                    }
                }
            };
        }

        public List<Publisher> GetPublishers() { return _Publishers; }

        public Publisher GetPublisherstById(int id)
        {
            return _Publishers.SingleOrDefault(x => x.Id == id);
        }

        public List<Book> GetBooksOfPublisher(int id, string? category)
        {
            return category is string
                ? GetPublisherstById(id).books
                    .Where(b => b.Category == category)
                    .ToList()
                : GetPublisherstById(id).books;
        }

        public Publisher AddPublisher(Publisher publisher)
        {
            publisher.Id = _Publishers.Count;
            _Publishers.Add(publisher);
            
           return publisher;
        }

        public void UpdatePublisher(int id, Publisher author)
        {
            Publisher existingAuthor = GetPublisherstById(id);
            if (existingAuthor != null)
            {
                existingAuthor.Name = author.Name;
                existingAuthor.City = author.City;
            }
        }

        public bool DeletePublisher(int id)
        {
            Publisher authorToRemove = GetPublisherstById(id);
            if (authorToRemove != null)
            {
                _Publishers.Remove(authorToRemove);
                return true;
            }
            return false;
        }
    }
}
