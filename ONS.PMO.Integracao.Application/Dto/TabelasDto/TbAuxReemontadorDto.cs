using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxReemontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int CodRee { get; set; }

    public string NomCurtoree { get; set; } = null!;

    public string? NomLongoree { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
