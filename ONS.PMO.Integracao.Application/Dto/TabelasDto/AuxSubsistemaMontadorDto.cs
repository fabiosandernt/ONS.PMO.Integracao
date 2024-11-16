using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxSubsistemaMontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public int CodSubsistema { get; set; }

    public int? NumTppatamares { get; set; }

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<AuxPequenaUsinaDto> TbAuxPequenausinas { get; set; } = new List<AuxPequenaUsinaDto>();

    public virtual ICollection<AuxSubsistemaContratoDto> TbAuxSubsistemacontratos { get; set; } = new List<AuxSubsistemaContratoDto>();

    public virtual ICollection<AuxSubsistemaIntervaloCustoDeficitDto> TbAuxSubsistemaintervalocustodeficits { get; set; } = new List<AuxSubsistemaIntervaloCustoDeficitDto>();
}
