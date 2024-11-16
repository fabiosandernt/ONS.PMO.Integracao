using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class RestricaoEletricaDto
{
    public int IdRestricao { get; set; }

    public string? CodEstruturacaores { get; set; }

    public virtual RestricaoDto IdRestricaoNavigation { get; set; } = null!;
}
