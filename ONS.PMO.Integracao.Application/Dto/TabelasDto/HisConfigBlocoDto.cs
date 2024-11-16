using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class HisConfigBlocoDto
{
    public int IdModifconfigblocoestudo { get; set; }

    public bool FlgProximoestudo { get; set; }

    public string? DscCabecalho { get; set; }

    public virtual ModifConfigBlocoEstudoDto IdModifconfigblocoestudoNavigation { get; set; } = null!;
}
