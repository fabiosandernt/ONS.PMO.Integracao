using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class RecuperacaoDadosBlocoDto
{
    public int IdRecuperacaodados { get; set; }

    public int IdBloco { get; set; }

    public virtual RecuperacaoDadoDto IdRecuperacaodadosNavigation { get; set; } = null!;
}
