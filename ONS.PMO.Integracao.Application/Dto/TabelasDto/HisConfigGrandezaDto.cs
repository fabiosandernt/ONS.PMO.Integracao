using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class HisConfigGrandezaDto
{
    public int IdModifconfigblocoestudo { get; set; }

    public int IdGrandezamontador { get; set; }

    public bool? FlgProximoestudo { get; set; }

    public virtual GrandezaMontadorDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual ModifConfigBlocoEstudoDto IdModifconfigblocoestudoNavigation { get; set; } = null!;
}
