using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoNegocio.Infrastructure.Dtos;
using ProyectoNegocio.Infrastructure.Interfaces;
using ProyectoNegocio.Service.Fragancy;

namespace ProyectoNegocio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrangrancyController : ControllerBase
    {
        private readonly IFragrancyService _fragrancyService;
        public FrangrancyController(IFragrancyService fragrancyService)
        {
            _fragrancyService = fragrancyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetFrangrancy(int id)
        {
            var fragrancy = await _fragrancyService.GetFragrancy(id);
            if (fragrancy == null)
            {
                return NotFound();
            }
            return Ok(fragrancy);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFrangrancy(FragrancyDTO fragrancyDTO)
        {
            await _fragrancyService.CreateFragrancyAsync(fragrancyDTO);
            return Created();
        }
    }
}
