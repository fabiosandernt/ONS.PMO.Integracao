﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ONS.PMO.Integracao.Application.Dto.PMO;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Implementation;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.Resources;

namespace ONS.PMO.Integracao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PMOController : ControllerBase
    {
        private readonly IPmoServices _pmoServices;
        private readonly ISemanaOperativaService _semanaOperativaService;
        public PMOController(IPmoServices pmoServices, ISemanaOperativaService semanaOperativaService)
        {
            _pmoServices = pmoServices;
            _semanaOperativaService = semanaOperativaService;
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

        [HttpDelete("ExcluirPMO")]
        public async Task<IActionResult> ExcluirPMO([FromBody] DadosPMODTO dto)
        {
            await _pmoServices.ExcluirPMOAsync(dto);
            return Ok(dto);
        }

        [HttpPost("IncluirPMO")]
        public async Task<IActionResult> IncluirPMOAsync([FromBody] IncluirPMODto dto)
        {
            var pmo = await _pmoServices.GerarPMOAsync(dto);
            return Ok(pmo);

        }

        [HttpPost("AlterarPMO")]
        public async Task<IActionResult> SalvarPMO([FromBody] TbPmoDto dto)
        {
            await _pmoServices.AtualizarMesesAdiantePMOAsync(dto.IdPmo, dto.QtdMesesadiante, dto.VerControleconcorrencia);
            return Ok(dto);
        }

        [HttpPost("IncluirSemana")]
        public async Task<IActionResult> IncluirSemanaOperativa([FromBody] InclusaoSemanaOperativaDTO dto)
        {
            await _pmoServices.IncluirSemanaOperativaAsync(dto);

            var message = BusinessMessage.Get("MS013");
            var SGIPMOMessages = BusinessMessage.Get("MS028");
            IList<string> mensagens = new List<string>();
            mensagens.Add(message.Value);
            string mensagemComSpan =
                string.Format("<img src='{0}' style='float:left; margin-right:5px'></img> {1} ",
                    Url.Content("~/Images/alert2.png"), SGIPMOMessages.Value);
            mensagens.Add(mensagemComSpan);
            return Ok(mensagens);
        }

        #region Abertura Estudo

        [HttpPost("AbrirEstudo")]
        public async Task<IActionResult> CarregarAbrirEstudo([FromBody] AberturaEstudoDTO aberturaEstudoDTO)
        {
            ValidarSelecaoSemanaOperativa(aberturaEstudoDTO.IdSemanaOperativa);

            DadosSemanaOperativaDTO dto = new DadosSemanaOperativaDTO()
            {
                IdSemanaOperativa = aberturaEstudoDTO.IdSemanaOperativa,
                VersaoPMO = aberturaEstudoDTO.VersaoSemanaOperativa
            };
            return Ok(await _semanaOperativaService.ObterSemanaOperativaValidaParaAbrirEstudo(dto));

        }

        private void ValidarSelecaoSemanaOperativa(int? idSemanaOperativa)
        {
            if (!idSemanaOperativa.HasValue)
            {
                var message = BusinessMessage.Get("MS025");
                throw new ArgumentException(message.Value);
            }
        }

        [HttpPost("AlterarSemanaOperativa")]
        public async Task<IActionResult> AlterarSemanaOperativa([FromBody] DadosAlteracaoSemanaOperativaDTO dto)
        {
            try
            {
                await _semanaOperativaService.AlterarSemanaOperativa(dto);
                var message = BusinessMessage.Get("MS013");
                return Ok(message.Value);
            }
            catch (BusinessValidationException validationException)
            {
                return BadRequest(new { Errors = validationException.Errors });
            }
        }


        [HttpPost("Resetar Gabarito")]
        public ActionResult ResetarGabarito([FromBody] ResetGabaritoDTO dto)
        {
            _semanaOperativaService.ResetarGabarito(dto);
            var message = BusinessMessage.Get("MS013");
            return Ok(message.Value);
        }

        #endregion

        #region Excluir Semana Operativa

        [HttpDelete("ExcluirSemana")]
        public async Task<IActionResult> ExcluirUltimaSemanaOperativaPMO([FromBody] TbPmoDto dto)
        {
            await _pmoServices.ExcluirUltimaSemanaOperativaAsync(dto.IdPmo, dto.VerControleconcorrencia);

            return Ok(dto);
        }

        #endregion

    }
}
