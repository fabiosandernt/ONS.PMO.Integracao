using Microsoft.AspNetCore.Mvc;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using System.Runtime.InteropServices;

namespace ONS.PMO.Integracao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PMOController : ControllerBase
    {
        private readonly IPmoServices _pmoServices;
        public PMOController(IPmoServices pmoServices)
        {
                _pmoServices = pmoServices;
        }
        
        [HttpGet("filter")]
        public async Task<IActionResult> GetByFilter([FromQuery] PmoFilter filter)
        {
            try
            {
                var result = await _pmoServices.ObterPMOPorFiltro(filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

         [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            //var result = await _pmoServices.GetByIdAsync(id);
            

            return Ok(/*result*/);
        }


    }
}
