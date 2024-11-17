using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxSubsistemaDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string CodSubsistema { get; set; } = null!;

    public virtual TbOrigemcoletumDto IdOrigemcoletaNavigation { get; set; } = null!;
}
