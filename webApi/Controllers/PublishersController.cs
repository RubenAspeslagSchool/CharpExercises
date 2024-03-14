using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublishersController : ControllerBase
    {
        private PublisherReposetory PublisherReposetory { get; init; }
       public PublishersController() 
        {
            PublisherReposetory = new PublisherReposetory();
        }
        [HttpGet(Name = "GetPublishers")]
        public List<Publisher> GetPublishers()
        {
            return PublisherReposetory.GetPublishers();
        }
        
        [HttpGet("{id:int}", Name = "GetPublisherById")] 
        public Publisher GetPublisher(int id)
        {
            return PublisherReposetory.GetPublisherstById(id);
        }

        [HttpGet("{id:int}/books", Name = "GetBooksByPublisherId")] 
        public List<Book> GetPublisherBooksByPublisherId(int id,[FromQuery] string? category)
        {
            return PublisherReposetory.GetBooksOfPublisher(id, category);
        }

    }
}
