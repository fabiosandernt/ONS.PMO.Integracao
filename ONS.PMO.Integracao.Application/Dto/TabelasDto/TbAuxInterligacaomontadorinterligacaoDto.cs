using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxInterligacaomontadorinterligacaoDto
{
    public int IdInterligacao { get; set; }

    public int IdOrigemcoletainterligacao { get; set; }

    public bool FlgSoma { get; set; }

    public virtual TbAuxInterligacaoDto IdInterligacaoNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletainterligacaoNavigation { get; set; } = null!;
}
