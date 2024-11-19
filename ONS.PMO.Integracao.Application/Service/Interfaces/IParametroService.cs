using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Enum;


namespace ONS.PMO.Integracao.Application.Service.Interfaces
{
    public interface IParametroService
    {
        /// <summary>
        /// Obtém o parâmetro pelo nome.
        /// </summary>
        /// <param name="paramento">Nome do parâmetro</param>
        /// <returns>Parametro</returns>
      ParametroPMO ObterParametro(ParametroEnum paramento);
    }
}
