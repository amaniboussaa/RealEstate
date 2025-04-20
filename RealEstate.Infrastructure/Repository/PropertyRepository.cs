using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Domain.Entity;
using RealEstate.Domain.Interface;

namespace RealEstate.Infrastructure.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        public static List<Property> lstProperties = new List<Property>()
         {
           new Property{  Id =1 ,Name= "Kirtesh Shah", Price =100 , Address="Vadodara"},
           new Property{  Id =2 ,Name= "Mahesh Shah", Price =500 , Address="Dabhoi"},
           new Property { Id = 3, Name = "Nitya Shah", Price = 250, Address = "Mumbai" },
           new Property { Id = 4, Name = "Dilip Shah", Price = 368, Address = "Dabhoi" },
           new Property { Id = 5, Name = "Hansa Shah", Price = 1850, Address = "Dabhoi" },
           new Property { Id = 6, Name = "Mita Shah", Price = 2600, Address = "Surat" }
        };
        public List<Property> GetAllProperties()
        {
            return lstProperties;
        }
    }
}
