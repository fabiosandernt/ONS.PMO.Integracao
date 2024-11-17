using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbHisconfiggrandezaDto
{
    public int IdModifconfigblocoestudo { get; set; }

    public int IdGrandezamontador { get; set; }

    public bool? FlgProximoestudo { get; set; }

    public virtual TbGrandezamontadorDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual TbModifconfigblocoestudoDto IdModifconfigblocoestudoNavigation { get; set; } = null!;
}
