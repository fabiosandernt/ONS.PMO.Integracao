using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbRecuperacaodadosblocoDto
{
    public int IdRecuperacaodados { get; set; }

    public int IdBloco { get; set; }

    public virtual TbRecuperacaodadoDto IdRecuperacaodadosNavigation { get; set; } = null!;
}
