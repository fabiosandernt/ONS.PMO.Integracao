using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxSubmercadoDto
{
    public string CodSubmercado { get; set; } = null!;

    public int IdOrigemcoletamontador { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
