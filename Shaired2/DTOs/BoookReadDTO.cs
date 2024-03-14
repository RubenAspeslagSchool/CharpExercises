using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaired2.DTOs
{
    public record BoookReadDTO()
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }
        public string Author { get; init; }
        public string Category { get; init; }
    };
}
