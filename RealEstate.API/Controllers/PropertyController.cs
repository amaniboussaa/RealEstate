using Microsoft.AspNetCore.Mvc;
using RealEstate.Domain.Interface;
using RealEstate.Domain.Entity;

namespace RealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Property>>> GetAllProperties()
        {
            return _propertyService.GetAllProperties();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetSingleProperty(int id)
        {
            var result = await _propertyService.GetSingleProperty(id);
            if (result is null)
                return NotFound("Property not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Property>>> AddProperty(Property Property)
        {
            var result = _propertyService.AddProperty(Property);
            return Ok(result);
        }
    }
}
