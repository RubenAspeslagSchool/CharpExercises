
namespace Shared.Mappings
{
    public class PublishersProfile: Profile
    {
        public PublishersProfile()
        {
            CreateMap<Publisher, PublisherReadDTO>();
            CreateMap<Publisher, PublisherDetailReadDTO>()
                .ForMember(dto => dto.BookTitles,
                           opt => opt.MapFrom(p => p.Books.Select(pb => pb.Title)));

            CreateMap<PublisherWriteDTO, Publisher>();
            CreateMap<PublisherUpdateDTO, Publisher>();
        }
    }
}
