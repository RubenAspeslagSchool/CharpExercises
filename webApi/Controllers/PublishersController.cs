using Microsoft.AspNetCore.Mvc;
using Shaired2.ExtentionMethods.Maping;
using Shaired2.DTOs;
using ClassLib.Reposetorys;

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
        public List<PublicherReadDTO> GetPublishers()
        {
            return PublisherReposetory.GetPublishers().ToReadDTOs();
        }
        
        [HttpGet("{id:int}", Name = "GetPublisherById")] 
        public PublicherReadDTO GetPublisher(int id)
        {
            return PublisherReposetory.GetPublisherstById(id).ToReadDTO();
        }

        [HttpGet("{id:int}/books", Name = "GetBooksByPublisherId")] 
        public List<BoookReadDTO> GetPublisherBooksByPublisherId(int id,[FromQuery] string? category)
        {
            return PublisherReposetory.GetBooksOfPublisher(id, category).ToReadDTOs();
        }

        [HttpPost]
        public ActionResult<int> AddAuthor(PublisherWriteDTO publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction(nameof(GetPublisher),
                PublisherReposetory.AddPublisher(publisher.ToPublisherEntity())
                .ToReadDTO());
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePublisher(int id, PublisherWriteDTO publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PublisherReposetory.UpdatePublisher(id, publisher.ToPublisherEntity());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            bool deleted = PublisherReposetory.DeletePublisher(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }



    }
}
