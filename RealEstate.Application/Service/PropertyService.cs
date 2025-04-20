
using RealEstate.Application.DTO;
using RealEstate.Application.Interface;
using RealEstate.Domain.Entity;
using RealEstate.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Service
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public async Task<PropertyDto> GetByIdAsync(int id)
        {
            var property = await _propertyRepository.GetByIdAsync(id);
            return new PropertyDto(property.Id, property.Name, property.Address, property.Price);
        }

        public async Task<IEnumerable<PropertyDto>> GetAllAsync()
        {
            var propertys = await _propertyRepository.GetAllAsync();
            return propertys.Select(p => new PropertyDto(p.Id, p.Name, p.Address, p.Price));
        }

        public async Task<PropertyDto> CreateAsync(CreatePropertyDto dto)
        {
            var property = new Property(dto.Name, dto.Address, dto.Price);
            var created = await _propertyRepository.AddAsync(property);
            return new PropertyDto(created.Id, created.Name, created.Address, created.Price);
        }

        public async Task UpdateAsync(int id, UpdatePropertyDto dto)
        {
            var property = await _propertyRepository.GetByIdAsync(id);
            property.UpdateDetails(dto.Name, dto.Address, dto.Price);
            await _propertyRepository.UpdateAsync(property);
        }

        public async Task DeleteAsync(int id)
        {
            await _propertyRepository.DeleteAsync(id);
        }
        public async Task<object> SimulateInvestmentAsync(int propertyId, double investmentAmount)
        {
            if (investmentAmount <= 0)
            {
                throw new ArgumentException("Investment amount must be greater than zero.");
            }

            var property = await _propertyRepository.GetByIdAsync(propertyId);

            if (property == null)
            {
                throw new ArgumentException($"Property with ID {propertyId} not found.");
            }
            double estimatedReturn = investmentAmount + (investmentAmount * 0.075);
            return new
            {
                propertyId = property.Id,
                investmentAmount,
                estimatedReturn,
                annualYield = 7.5
            };
        }

    }

}
