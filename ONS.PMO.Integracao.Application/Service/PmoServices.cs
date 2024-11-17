using AutoMapper;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Interfaces;
using ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Dto.TabelasDto;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.PMO;
using Microsoft.AspNetCore.DataProtection.Repositories;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Application.Service
{
    public class PmoServices : IPmoServices
    {
          
        private readonly IDadosResultadoPmoRepository _dadosResultadoPmoRepository;
        private readonly IMapper _mapper;
        private readonly IPmoRepository _pmoRepository;


        public PmoServices(IMapper mapper, IDadosResultadoPmoRepository dadosResultadoPmoRepository, IPmoRepository PMORepository)
        {
            _pmoRepository = PMORepository;
            _dadosResultadoPmoRepository = dadosResultadoPmoRepository;
            _mapper = mapper;
        }

        public async Task<PmoDto> GetByIdAsync(int id)
        {
            var pmo = await _pmoRepository.GetByIdAsync(id);

            var pmoDto = _mapper.Map<PmoDto>(pmo);

            return pmoDto;
        }

        public async Task<ICollection<PmoDto>> GetByFilter(PmoFilter filter)
        {
            var query = _pmoRepository.GetByFilter(filter);
            var pmosDto = _mapper.Map<List<PmoDto>>(query);
            return pmosDto;
        }

        public async Task<DadoResultadoPmoDto> ObterDadosMontadorDisponibilidadeInflexibilidadeCVU(DisponibilidadeFilter filter)
        {
            var query = await _dadosResultadoPmoRepository.GetDadoResultPmosAsync(filter);
            var resultados = new List<ResultadoPmoDto>();
            var resultadoFinal = new DadoResultadoPmoDto() { Pmo = resultados,Offset=filter.Offset??0 };
            foreach (var dadoResultado in query)
            {
                var pmo = resultados.FirstOrDefault(x => x.IdPmo == dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdPmo);
                if (pmo == null)
                {
                    pmo = new ResultadoPmoDto
                    {
                        IdPmo = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdPmo,
                        ListaResultado = new List<CVUListaResultadoPmoDto>()
                    };
                    resultados.Add(pmo);
                }
                var resultado = pmo.ListaResultado.FirstOrDefault(r => r.ListaResultadoId == dadoResultado.IdListaresultadopmo);
                if (resultado == null)
                {
                   resultado = new CVUListaResultadoPmoDto
                   {    
                        ListaResultadoId = dadoResultado.IdListaresultadopmo,
                        IdImportacao = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmo??0,
                       SemanaOperativa = new Dto.DisponibilidadeCVU.SemanaOperativaDto
                       {
                           IdSemanaOperativa = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdSemanaoperativa,
                           NomSemanaOperativa = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.NomSemanaoperativa,
                           DataInicioSemana = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.DatIniciosemana,
                           DataFimSemana = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.DatFimsemana,
                           DataReuniao = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.DatReuniao,
                           NumRevisao = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.NumRevisao ?? 0,
                           dscSituacaoSemanaOperativa = dadoResultado.IdListaresultadopmoNavigation.IdImportacaopmoNavigation.IdSemanaoperativaNavigation.IdTpsituacaosemanaoperNavigation.DscSituacaosemanaoper,

                       },
                       Agentes = new List<AgenteDto>()
               
                   };
                    pmo.ListaResultado.Add(resultado);
                }
                var agente = resultado.Agentes.FirstOrDefault(a => a.NomeCurto == dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.NomCurto);
                if (agente == null) {
                    agente = new AgenteDto
                    {
                        NomeCurto = dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.NomCurto,
                        NomeLongo = dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.NomLongo,
                        CodDpp = dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.CodDpp,
                        Insumo = new List<InsumoDto>()
                        
                    };
                    resultado.Agentes.Add(agente);
                }
                var insumo = agente.Insumo.FirstOrDefault(x => x.MnemonicoId == dadoResultado.IdMnemonicopmo);
                if (insumo == null) {
                    insumo = new InsumoDto
                    {
                        IdDadoResultado = dadoResultado.IdDadoresultpmo,
                        codSubsistema= dadoResultado.IdListaresultadopmoNavigation.IdOrigemresultadopmoNavigation.CodOrigemresultadopmopai,
                        codTpGeracao= dadoResultado.IdListaresultadopmoNavigation.TbAuxUsinamontador.CodTpgeracao,
                        MnemonicoId = dadoResultado.IdMnemonicopmo,
                        Grandezas = new List<CVUGrandezaDto>(),
                       
                    };
                agente.Insumo.Add(insumo);
                }
                var grandeza = insumo.Grandezas.FirstOrDefault(x => x.NomeGrandeza == dadoResultado.IdMnemonicopmoNavigation.NomMnemonicopmo);
                if (grandeza == null) {
                    grandeza = new CVUGrandezaDto
                    {
                        CodMnemonicoPMO = dadoResultado.IdMnemonicopmoNavigation.CodMnemonicopmo,
                        NomeGrandeza = dadoResultado.IdMnemonicopmoNavigation.NomMnemonicopmo,
                        Patamares = new List<PatamarPmoDto>()
                    };
                    insumo.Grandezas.Add(grandeza);
                
                }
                var patamares = grandeza.Patamares.FirstOrDefault(x => x.IdPatamar == dadoResultado.IdTppatamar);
                if (patamares == null) {
                    patamares = new PatamarPmoDto
                    {
                        IdPatamar = dadoResultado.IdTppatamar ?? 0,
                        Patamar = dadoResultado.Tppatamar,
                        Valor = dadoResultado.DscValorcoletadomnemonico
                    };
                    grandeza.Patamares.Add(patamares);
                }
            }
                return resultadoFinal;
           

        }
     
    }
  
}
