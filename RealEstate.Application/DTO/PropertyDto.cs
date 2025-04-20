using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.DTO
{
    public record PropertyDto(int Id, string Name, string Address, decimal Price);

    public record CreatePropertyDto(string Name, string Address, decimal Price);

    public record UpdatePropertyDto(string Name, string Address, decimal Price);
}
