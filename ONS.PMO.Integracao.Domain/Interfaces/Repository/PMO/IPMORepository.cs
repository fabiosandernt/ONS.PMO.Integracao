using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.Base;


namespace ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO
{
    public interface IPMORepository : IRepository<Pmo>
    {

        Pmo ObterPorFiltro(IBaseFilter filtro);
        Pmo ObterPorFiltroExterno(IBaseFilter filtro);
        int ObterQuantidadeSemanasPMO(int idSemanaOperativa);
    }
}
