using ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU;
using ONS.PMO.Integracao.Application.Dto.TabelasDto;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU;

namespace ONS.PMO.Integracao.Application.Service.Interfaces
{
    public interface IPmoServices
    {
        Task<DadoResultadoPmoDto> ObterDadosMontadorDisponibilidadeInflexibilidadeCVU(DisponibilidadeFilter filter);
        Task<ICollection<PmoDto>> GetByFilter(PmoFilter filter);
        Task<PmoDto> GetByIdAsync(int id);
    }
}

