using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO
{
    public interface IGabaritoRepository : IRepository<Gabarito>
    {
        //PagedResult<GabaritoAgrupadoAgenteOrigemColetaDTO> ConsultarAgrupadoPorAgenteTipoOrigemPaginado(GabaritoOrigemColetaFilter filter);

        IList<Gabarito> ConsultarPorGabaritoFilter(GabaritoConfiguracaoFilter filter);

        //PagedResult<Gabarito> ConsultarPorGabaritoFilterPaginado(GabaritoConfiguracaoFilter filter);

        Gabarito ObterPorColetaInumoOrigemColeta(int idColetaInsumo, string idOrigemColeta);

        IEnumerable<Gabarito> ConsultarParaRemover(IList<int> ids);

        void DeletarPorIdSemanaOperativa(int idSemanaOperativa);

        IList<Gabarito> ConsultarGabaritoParticipaBloco(int idSemanaOperativa);

        //IList<GabaritoConfiguracaoBaseDTO<ConfiguracaoUsinaDTO>> ConsultarUsinaPorGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoConfiguracaoBaseDTO<ConfiguracaoUGEDTO>> ConsultarUGEPorGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoConfiguracaoBaseDTO<ConfiguracaoReservatorioDTO>> ConsultarReservatorioPorGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoConfiguracaoBaseDTO<ConfiguracaoSubsistemaDTO>> ConsultarSubsistemaPorGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoParticipantesBaseDTO<ReservatorioParticipanteGabaritoDTO>> ConsultarReservatoriosParticipantesGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoParticipantesBaseDTO<UsinaParticipanteGabaritoDTO>> ConsultarUsinasParticipantesGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoParticipantesBaseDTO<AgenteParticipanteGabaritoDTO>> ConsultarAgentesParticipantesGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoConfiguracaoBaseDTO<ConfiguracaoInsumoNaoEstruturadoDTO>> ConsultarAgentesPodemEnviarDadosNaoEstruturadosPorGabarito(bool isPadrao, string nomeRevisao = "");

        //IList<GabaritoConfiguracaoBaseDTO<ConfiguracaoGeracaoComplementar>> ConsultarAgentesComGeracaoComplementar(bool isPadrao, string nomeRevisao = "");

    }
}
