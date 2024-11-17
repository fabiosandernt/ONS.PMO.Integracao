using Microsoft.AspNetCore.Mvc;
//using ONS.Core.POP.Provider.Schemas;
using ONS.PMO.Integracao.Api.Shared;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;


namespace ONS.PMO.Integracao.Api.Controllers
{
    [Route("api/Integracao/Pmo")]
    [ApiController]    
    //[ClaimRequirement(POPClaimTypes.Operation, "ConsultarCVU")]

    public class IntegracaoController : ControllerBase
    {       
        private readonly IPmoServices _pmoServices;

        public IntegracaoController(IPmoServices pmoServices)
        {            
            _pmoServices = pmoServices;
        }     
        [HttpGet("MontadorDisponibilidadeInflexibilidadeCVU")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObterDadosDisponibilidadeInflexibilidadeCVU([FromQuery] DisponibilidadeFilter filter)
        {
            if (!filter.DataInicioSemana.HasValue||!filter.DataFimSemana.HasValue)
            {
                return BadRequest("O campo DataInicioSemana e DataFimSemana são obrigatórios.");
            }
            var result = await _pmoServices.ObterDadosMontadorDisponibilidadeInflexibilidadeCVU(filter);
            return Ok(result);
        }


       
    }
}   

