using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxSubsistemaintervalocustodeficitDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdIntervalocustodeficit { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual TbAuxIntervalocustodeficitDto IdIntervalocustodeficitNavigation { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxSubsistemamontadorDto IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
