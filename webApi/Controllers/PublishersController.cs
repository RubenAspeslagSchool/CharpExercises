﻿using Microsoft.AspNetCore.Mvc;
using Shaired2.ExtentionMethods.Maping;
using Shaired2.DTOs;
using ClassLib.Reposetorys;
using webApi.Wrappers;
using Shaired2.ExtentionMethods.paging;
using Shaired2.Filter;
using AutoMapper;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublishersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IPublisherReposetory _publisherReposetory;
       public PublishersController() 
        {
            _publisherReposetory = new PublisherReposetory();
        }

        [HttpGet(Name = "GetPublishers")]
        public ActionResult<PagedResponse<List<PublicherReadDTO>>> GetPublishers([FromQuery] PaginationFilter paginationFilter, [FromServices] IConfiguration config)
        {
            List<Publisher> allPublishers = _publisherReposetory.GetPublishers();
            return Ok(new PagedResponse<IEnumerable<PublicherReadDTO>>(
                       allPublishers
                           .ToPagedList(paginationFilter.PageNumber, paginationFilter.PageSize)
                           .ToReadDTOs()
                           .ToList(),
                       paginationFilter.PageNumber,
                       paginationFilter.PageSize)
            {
                TotalRecords = allPublishers.Count()
            });

        }

        [HttpGet("{id:int}", Name = "GetPublisherById")] 
        public PublicherReadDTO GetPublisher(int id)
        {
            return _publisherReposetory.GetPublisherstById(id).ToReadDTO();
        }

        [HttpGet("{id:int}/books", Name = "GetBooksByPublisherId")] 
        public List<BoookReadDTO> GetPublisherBooksByPublisherId(int id,[FromQuery] string? category)
        {
            return _publisherReposetory.GetBooksOfPublisher(id, category).ToReadDTOs();
        }

        [HttpPost]
        public ActionResult<int> AddAuthor(PublisherWriteDTO publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction(nameof(GetPublisher),
                _publisherReposetory.AddPublisher(publisher.ToPublisherEntity())
                .ToReadDTO());
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePublisher(int id, PublisherWriteDTO publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _publisherReposetory.UpdatePublisher(id, publisher.ToPublisherEntity());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            bool deleted = _publisherReposetory.DeletePublisher(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }



    }
}
