using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Domain.Entity;

namespace RealEstate.Domain.Interface
{
    public interface IPropertyRepository
    {
        Task<Property> GetByIdAsync(int id);
        Task<IEnumerable<Property>> GetAllAsync();
        Task<Property> AddAsync(Property property);
        Task UpdateAsync(Property property);
        Task DeleteAsync(int id);
    }
}
