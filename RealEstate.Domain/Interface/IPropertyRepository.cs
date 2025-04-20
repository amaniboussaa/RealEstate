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
        List<Property> GetAllProperties();
    }
}
