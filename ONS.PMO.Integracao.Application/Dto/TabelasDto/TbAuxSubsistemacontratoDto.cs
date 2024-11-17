using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxSubsistemacontratoDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdContrato { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual TbAuxContratoDto IdContratoNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxSubsistemamontadorDto IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
