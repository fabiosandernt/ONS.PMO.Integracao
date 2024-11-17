using AspNetCore.IQueryable.Extensions;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Filter;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;

namespace ONS.PMO.Integracao.Infraestructure.Repository
{
    public class PMORepository : Repository<Pmo>, IPMORepository
    {
        public PMORepository(WebPmoContext context) : base(context)
        {

        }

        public Pmo ObterPorFiltro(IBaseFilter filtro)
        {

            var query = _query.AsQueryable().AsNoTracking()
                 .Include(x => x.TbSemanaoperativas)                  
                 .Apply(filtro);

            return query.FirstOrDefault();
        }

        public Pmo ObterPorFiltroExterno(IBaseFilter filtro)
        {
            throw new NotImplementedException();
        }

        public int ObterQuantidadeSemanasPMO(int idSemanaOperativa)
        {
            throw new NotImplementedException();
        }
    }
}
