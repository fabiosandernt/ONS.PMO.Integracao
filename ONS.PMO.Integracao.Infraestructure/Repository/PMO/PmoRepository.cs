using AspNetCore.IQueryable.Extensions;
using Microsoft.EntityFrameworkCore;
using ONS.PMO.Integracao.Domain.Entidades.Base;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Interfaces.PMO;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;


namespace ONS.PMO.Integracao.Infraestructure.Repository.PMO
{
    public class PmoRepository : Repository<Pmo>, IPmoRepository
    {
        public PmoRepository(WebPmoContext context) : base(context)
        {
        }
        public Pmo GetByFilter(IBaseFilter filtro)
        {

            var query = _query.AsQueryable().AsNoTracking()
                 .Include(x => x.TbSemanaoperativas)               
                 .Apply(filtro);

            return query.FirstOrDefault();
        }
    }
}
