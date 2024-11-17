
using Microsoft.AspNetCore.Mvc;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;

namespace ONS.PMO.Integracao.Api.Controllers
{
    [Route("api/[controlLer]")]
    [ApiController]
    public class InsumoController : ControllerBase
    {
        private readonly IInsumoService _insumoService;
        public InsumoController(IInsumoService insumoService)
        {
                _insumoService = insumoService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            try
            {
                var insumos = await _insumoService.GetAllAsync();
                return Ok(insumos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("filter")]
        public async Task<IActionResult> GetByFilter([FromQuery] InsumoFilter filter)
        {
            try
            {
                var result = _insumoService.GetByQueryable(filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
