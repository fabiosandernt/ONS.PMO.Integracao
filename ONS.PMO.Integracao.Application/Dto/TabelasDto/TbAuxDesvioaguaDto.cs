using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxDesvioaguaDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdUsinamontadorretirada { get; set; }

    public int? IdUsinamontadorretorno { get; set; }

    public string? DscDesvioagua { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontadorDto IdUsinamontadorretiradaNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontadorDto? IdUsinamontadorretornoNavigation { get; set; }
}
