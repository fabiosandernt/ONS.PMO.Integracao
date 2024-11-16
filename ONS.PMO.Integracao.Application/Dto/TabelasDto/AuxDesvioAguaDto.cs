using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxDesvioAguaDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdUsinamontadorretirada { get; set; }

    public int? IdUsinamontadorretorno { get; set; }

    public string? DscDesvioagua { get; set; }

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxUsinaMontadorDto IdUsinamontadorretiradaNavigation { get; set; } = null!;

    public virtual AuxUsinaMontadorDto? IdUsinamontadorretornoNavigation { get; set; }
}
