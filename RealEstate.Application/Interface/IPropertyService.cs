using RealEstate.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interface
{
    public interface IPropertyService

    { 
        Task<PropertyDto> GetByIdAsync(int id);
        Task<IEnumerable<PropertyDto>> GetAllAsync();
        Task<PropertyDto> CreateAsync(CreatePropertyDto dto);
        Task UpdateAsync(int id, UpdatePropertyDto dto);
        Task DeleteAsync(int id);
    }
}
