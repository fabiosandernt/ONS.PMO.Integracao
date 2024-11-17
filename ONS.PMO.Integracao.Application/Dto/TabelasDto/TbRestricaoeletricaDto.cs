using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbRestricaoeletricaDto
{
    public int IdRestricao { get; set; }

    public string? CodEstruturacaores { get; set; }

    public virtual TbRestricaoDto IdRestricaoNavigation { get; set; } = null!;
}
