using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxUsinaconjuntoDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int? IdUsinamontador { get; set; }

    public int? NumGruge { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontadorDto? IdUsinamontadorNavigation { get; set; }
}
