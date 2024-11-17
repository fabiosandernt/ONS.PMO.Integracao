using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxInterligacaomontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurtosubsistemade { get; set; } = null!;

    public string CodSubsistemade { get; set; } = null!;

    public string NomCurtosubsistemapara { get; set; } = null!;

    public string CodSubsistemapara { get; set; } = null!;

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
