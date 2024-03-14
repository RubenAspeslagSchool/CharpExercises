using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaired2.DTOs
{
    public record StudentReadDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public bool Succeeded { get; init; }
    }
}
