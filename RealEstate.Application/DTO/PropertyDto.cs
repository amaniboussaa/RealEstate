using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.DTO
{
    public record PropertyDto(int Id, string Name, string Address, decimal Price);

    public record CreatePropertyDto(
       [Required] string Name,
       [Required] string Address,
       [Range(0, double.MaxValue)] decimal Price);

    public record UpdatePropertyDto(
        [Required] string Name,
        [Required] string Address,
        [Range(0, double.MaxValue)] decimal Price);
}
