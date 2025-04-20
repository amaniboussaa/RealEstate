using RealEstate.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Interface
{
    public interface IPropertyService
    {
        List<Property> GetAllProperties();

        Task<Property> GetSingleProperty(int id);
        List<Property> AddProperty(Property hero);
    }
}
