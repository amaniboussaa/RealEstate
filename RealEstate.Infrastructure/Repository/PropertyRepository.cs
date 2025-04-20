using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Entity;
using RealEstate.Domain.Interface;
using RealEstate.Infrastructure.Data;

namespace RealEstate.Infrastructure.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly DataContext _context;

        public PropertyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Property> GetByIdAsync(int id)
        {
            return await _context.Propertys.FindAsync(id);
        }

        public async Task<IEnumerable<Property>> GetAllAsync()
        {
            return await _context.Propertys.ToListAsync();
        }

        public async Task<Property> AddAsync(Property p)
        {
            await _context.Propertys.AddAsync(p);
            await _context.SaveChangesAsync();
            return p;
        }

        public async Task UpdateAsync(Property p)
        {
            _context.Propertys.Update(p);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var p = await GetByIdAsync(id);
            _context.Propertys.Remove(p);
            await _context.SaveChangesAsync();
        }
    }

}
