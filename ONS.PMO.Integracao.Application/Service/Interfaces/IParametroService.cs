using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

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
