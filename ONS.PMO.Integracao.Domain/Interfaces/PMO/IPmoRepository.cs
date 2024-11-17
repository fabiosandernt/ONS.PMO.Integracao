using ONS.PMO.Integracao.Domain.Entidades.Base;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.RespositoryBase;


namespace ONS.PMO.Integracao.Domain.Interfaces.PMO
{
    public interface IPmoRepository : IRepository<Pmo>
    {

        Pmo GetByFilter(IBaseFilter filtro);
        //PMO ObterPorFiltroExterno(PMOFilter filtro);
        //int ObterQuantidadeSemanasPMO(int idSemanaOperativa);
    }
}
