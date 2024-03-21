using ClassLib.Models;

namespace ClassLib.Reposetorys
{
    public interface IPublisherReposetory
    {
        List<Book> GetBooksOfPublisher(int id, string? category);
        List<Publisher> GetPublishers();
        Publisher GetPublisherstById(int id);
    }
}