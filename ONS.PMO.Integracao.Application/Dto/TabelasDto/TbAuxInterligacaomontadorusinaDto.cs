using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxInterligacaomontadorusinaDto
{
    public int IdOrigemcoletainterligprinc { get; set; }

    public int IdOrigemcoletausina { get; set; }

    public bool FlgSoma { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletainterligprincNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletausinaNavigation { get; set; } = null!;
}
