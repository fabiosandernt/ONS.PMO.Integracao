using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class OrigemColetumDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string TipOrigemcoleta { get; set; } = null!;

    public string NomExibicao { get; set; } = null!;

    public virtual AuxReservatorioDto? TbAuxReservatorio { get; set; }

    public virtual AuxSubsistemaDto? TbAuxSubsistema { get; set; }

    public virtual AuxUnidadeGeradoraDto? TbAuxUnidadegeradora { get; set; }

    public virtual AuxUsinaDto? TbAuxUsina { get; set; }

    public virtual ICollection<GabaritoDto> TbGabaritos { get; set; } = new List<GabaritoDto>();
}
