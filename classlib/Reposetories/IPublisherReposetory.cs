using ClassLib.Models;

namespace ClassLib.Reposetorys
{
    public interface IPublisherReposetory
    {
        Publisher AddPublisher(Publisher publisher);
        bool DeletePublisher(int id);
        List<Book> GetBooksOfPublisher(int id, string? category);
        List<Publisher> GetPublishers();
        Publisher GetPublisherstById(int id);
        void UpdatePublisher(int id, Publisher author);
    }
}