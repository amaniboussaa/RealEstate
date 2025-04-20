using Microsoft.AspNetCore.Mvc;
using RealEstate.Application.DTO;
using RealEstate.Application.Interface;

namespace RealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertysController : ControllerBase
    {
        private readonly IPropertyService _propertyService;

        public PropertysController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyDto>>> GetAll()
        {
            var propertys = await _propertyService.GetAllAsync();
            return Ok(propertys);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyDto>> GetById(int id)
        {
            var property = await _propertyService.GetByIdAsync(id);
            return Ok(property);
        }

        [HttpPost]
        public async Task<ActionResult<PropertyDto>> Create(CreatePropertyDto dto)
        {
            var property = await _propertyService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = property.Id }, property);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdatePropertyDto dto)
        {
            await _propertyService.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _propertyService.DeleteAsync(id);
            return NoContent();
        }
    }
}
