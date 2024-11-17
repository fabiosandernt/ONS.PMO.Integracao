using AspNetCore.IQueryable.Extensions;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;


namespace ONS.PMO.Integracao.Infraestructure.Repository
{
    public class InsumoRepository : Repository<InsumoPMO>, IInsumoRepostitory
    {
        public InsumoRepository(WebPmoContext context) : base(context)
        {
        }

        public IEnumerable<InsumoPMO> GetAllInsumosCustom(ICustomQueryable filter)
        {
            var query = _query.AsQueryable()
                .Apply(filter)
                .Include(x => x.TbGabaritos)
                .Include(x=> x.TbColetainsumos);

            return  query.ToList();
        }

    }

}

