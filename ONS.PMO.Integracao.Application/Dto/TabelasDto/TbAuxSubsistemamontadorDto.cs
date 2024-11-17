using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxSubsistemamontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public int CodSubsistema { get; set; }

    public int? NumTppatamares { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<TbAuxPequenausinaDto> TbAuxPequenausinas { get; set; } = new List<TbAuxPequenausinaDto>();

    public virtual ICollection<TbAuxSubsistemacontratoDto> TbAuxSubsistemacontratos { get; set; } = new List<TbAuxSubsistemacontratoDto>();

    public virtual ICollection<TbAuxSubsistemaintervalocustodeficitDto> TbAuxSubsistemaintervalocustodeficits { get; set; } = new List<TbAuxSubsistemaintervalocustodeficitDto>();
}
