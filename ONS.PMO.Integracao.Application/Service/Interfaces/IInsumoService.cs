using ONS.PMO.Integracao.Application.Dto.TabelasDto;
using ONS.PMO.Integracao.Application.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Interfaces
{
    public interface IInsumoService 
    {
        Task<IEnumerable<TbInsumopmoDto>> GetAllAsync();
        ICollection<TbInsumopmoDto> GetByQueryable(InsumoFilter filter);
    }
}
