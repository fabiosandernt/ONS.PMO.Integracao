using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxUsinamnemonicoDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdOrigemcoletamnemonico { get; set; }

    public int IdOrigemcoletausina { get; set; }

    public virtual TbAuxMnemonicomontadorDto IdOrigemcoletamnemonicoNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontadorDto IdOrigemcoletausinaNavigation { get; set; } = null!;
}
