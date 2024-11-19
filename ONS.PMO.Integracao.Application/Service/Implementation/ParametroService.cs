using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Enum;
using ONS.PMO.Integracao.Domain.Enums;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;


namespace ONS.PMO.Integracao.Application.Service.Implementation
{
    public class ParametroService : IParametroService
    {
        private IParametroRepository _parametroRepository { get; set; }
        public ParametroService(IParametroRepository parametroRepository)
        {
            _parametroRepository = parametroRepository;
        }
        public async Task<ParametroPMO> ObterParametroAsync(ParametroEnum paramentoEnum)
        {

            ParametroPMO parametro = await _parametroRepository.ObterPorTipoAsync(paramentoEnum);
            if (parametro == null || string.IsNullOrEmpty(parametro.ValParametropmo))
            {
                string mensagem = string.Format("Parâmetro {0} não cadastrado", paramentoEnum.GetDescription());
                throw new ArgumentException(mensagem);
            }
            return parametro;

        }
    }
}
