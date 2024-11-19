using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Enum;
using ONS.PMO.Integracao.Domain.Enums;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using ONS.PMO.Integracao.Infraestructure.Context;
using ONS.PMO.Integracao.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Infraestructure.Repository.PMO
{
    public class ParametroRepository : Repository<ParametroPMO>, IParametroRepository
    {
        public ParametroRepository(WebPmoContext context) : base(context)
        {
             
        }

        public ParametroPMO ObterPorTipo(ParametroEnum parametro)
        {
            string nomeParametro = parametro.GetDescription();
            var parametroPMO = _query.FirstOrDefault(param => param.NomParametropmo == nomeParametro);
            return parametroPMO;
        }
    }
            
}
