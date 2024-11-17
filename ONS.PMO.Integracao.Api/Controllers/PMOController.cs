using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Implementation;
using ONS.PMO.Integracao.Application.Service.Interfaces;

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
            var result = await _pmoServices.GetByIdAsync(id);


            return Ok(result);
        }

        [HttpPost("Excluir")]
        public async Task<IActionResult> ExcluirPMO(DadosPMODTO dto)
        {
            await _pmoServices.ExcluirPMOAsync(dto);
            return Ok(dto);
        }

        [HttpPost("Incluir PMO")]
        public async Task<IActionResult> IncluirPMOAsync([FromBody] TbPmoDto dto)
        {
            var pmo = await _pmoServices.GerarPMOAsync(dto);
            return Ok(pmo);

        }

        [HttpPost("Alterar PMO")]
        public async Task<IActionResult> SalvarPMO(TbPmoDto dto)
        {
            await _pmoServices.AtualizarMesesAdiantePMOAsync(dto.IdPmo, dto.QtdMesesadiante, dto.VerControleconcorrencia);
            return Ok(dto);
        }
        #region Excluir Semana Operativa

        [HttpPost("Excluir Semana")]
        public async Task<IActionResult> ExcluirUltimaSemanaOperativaPMO(TbPmoDto dto)
        {
            await _pmoServices.ExcluirUltimaSemanaOperativaAsync(dto.IdPmo, dto.VerControleconcorrencia);

            return Ok(dto);
        }

        #endregion
    }
}
