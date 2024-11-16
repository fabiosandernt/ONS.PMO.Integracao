using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxUnidadeGeradoraDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string IdOrigemcoletausinapai { get; set; } = null!;

    public int CodDpp { get; set; }

    public double? ValPotencianominal { get; set; }

    public int? NumConjunto { get; set; }

    public int? NumMaquina { get; set; }

    public virtual OrigemColetumDto IdOrigemcoletaNavigation { get; set; } = null!;

    public virtual AuxUsinaDto IdOrigemcoletausinapaiNavigation { get; set; } = null!;

    public virtual ICollection<DadoColetaManutencaoDto> TbDadocoletamanutencaos { get; set; } = new List<DadoColetaManutencaoDto>();

    public virtual ICollection<ManutencaoPmoDto> TbManutencaopmos { get; set; } = new List<ManutencaoPmoDto>();
}
