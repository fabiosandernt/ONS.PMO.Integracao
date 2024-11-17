using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxUnidadegeradoramontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int? IdOrigemcoletamontadorusina { get; set; }

    public string NomCurtouge { get; set; } = null!;

    public int NumUge { get; set; }

    public int IdGruge { get; set; }

    public string NomCurtousina { get; set; } = null!;

    public int CodUsiplanejamento { get; set; }

    public string? NomCurtosubsistema { get; set; }

    public string CodSubsistema { get; set; } = null!;

    public int? NumGruge { get; set; }

    public double? ValPotencianominal { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontadorDto? IdOrigemcoletamontadorusinaNavigation { get; set; }

    public virtual ICollection<TbManutencaoprogramadumDto> TbManutencaoprogramada { get; set; } = new List<TbManutencaoprogramadumDto>();
}
