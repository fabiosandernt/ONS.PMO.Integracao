using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbOrigemcoletumDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string TipOrigemcoleta { get; set; } = null!;

    public string NomExibicao { get; set; } = null!;

    public virtual TbAuxReservatorioDto? TbAuxReservatorio { get; set; }

    public virtual TbAuxSubsistemaDto? TbAuxSubsistema { get; set; }

    public virtual TbAuxUnidadegeradoraDto? TbAuxUnidadegeradora { get; set; }

    public virtual TbAuxUsinaDto? TbAuxUsina { get; set; }

    public virtual ICollection<TbGabaritoDto> TbGabaritos { get; set; } = new List<TbGabaritoDto>();
}
