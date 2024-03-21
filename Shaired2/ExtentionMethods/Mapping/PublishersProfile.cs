
using Shared.DTO;

namespace Shared.Mappings
{
    public class PublishersProfile: Profile
    {
        public PublishersProfile()
        {
            CreateMap<Publisher, PublicherReadDTO>();
                     
            CreateMap<PublisherWriteDTO, Publisher>();
            CreateMap<PublisherUpdateDTO, Publisher>();
        }
    }
}
