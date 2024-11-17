using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbRecuperacaodadosagentepmoDto
{
    public int IdRecuperacaodados { get; set; }

    public string AgeId { get; set; } = null!;

    public virtual TbRecuperacaodadoDto IdRecuperacaodadosNavigation { get; set; } = null!;
}
