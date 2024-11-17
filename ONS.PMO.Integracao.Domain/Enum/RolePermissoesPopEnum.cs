using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Enum
{
    public enum RolePermissoesPopEnum
    {
        [Description("AdministradorSistema")]
        AdministradorSistema = 1,

        [Description("AdministradorProcesso")]
        AdministradorProcesso,

        [Description("Agente")]
        Agente,

        [Description("GMC-1")]
        GMC_1,

        [Description("GPD-1")]
        GPD_1,

        [Description("GPD-2")]
        GPD_2,

        [Description("GPD-3")]
        GPD_3,

        [Description("GPO-1")]
        GPO_1,

        [Description("Leitor")]
        Leitor,

        [Description("RepresentanteCCEE")]
        RepresentanteCCEE
    }
}
