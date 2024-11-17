using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;


namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO
{
    public interface IPMORepository : IRepository<Pmo>
    {
        Task ExcluirPMOAsync(Pmo dto);
        Pmo ObterPorFiltro(IBaseFilter filtro);
        //PMO ObterPorFiltroExterno(PMOFilter filtro);
        //int ObterQuantidadeSemanasPMO(int idSemanaOperativa);
    }
}
