using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaired2.DTOs
{
    public record PublisherWriteDTO
    {
        public string Name { get; init; }
        public string City { get; init; }
    }
}
