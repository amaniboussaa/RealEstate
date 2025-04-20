using RealEstate.Domain.Entity;
using RealEstate.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application
{
    public class PropertyService : IPropertyService
    {

        public List<Property> AddProperty(Property hero)
        {
            throw new NotImplementedException();
        }

        public List<Property> GetAllProperties()
        {
            throw new NotImplementedException();
        }

        public Task<Property> GetSingleProperty(int id)
        {
            throw new NotImplementedException();
        }
    }

}
