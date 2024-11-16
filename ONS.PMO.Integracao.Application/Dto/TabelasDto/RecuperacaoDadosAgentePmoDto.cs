using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class RecuperacaoDadosAgentePmoDto
{
    public int IdRecuperacaodados { get; set; }

    public string AgeId { get; set; } = null!;

    public virtual RecuperacaoDadoDto IdRecuperacaodadosNavigation { get; set; } = null!;
}
