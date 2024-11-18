using AutoMapper;
using ONS.PMO.Integracao.Application.Dto.TabelasDto;
using ONS.PMO.Integracao.Application.Filter;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Interfaces;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class InsumoService : IInsumoService
    {
        private readonly IInsumoRepostitory _insumoRepository;
        private readonly IMapper _mapper;

        public InsumoService(IInsumoRepostitory insumoRepository, IMapper mapper)
        {
            _insumoRepository = insumoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TbInsumopmoDto>> GetAllAsync()
        {
            var insumos = await _insumoRepository.GetAllAsync();
            return _mapper.Map<List<TbInsumopmoDto>>(insumos);
        }

        public ICollection<TbInsumopmoDto> GetByQueryable(InsumoFilter filter)
        {
            //var query = _insumoRepository.GetAllInsumosCustom(filter);
            var query = _insumoRepository.GetByQueryable(filter);
            var insumosDto = _mapper.Map<List<TbInsumopmoDto>>(query);
            return insumosDto;
        }
    }
}
