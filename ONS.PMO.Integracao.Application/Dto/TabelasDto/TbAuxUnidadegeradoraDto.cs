using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxUnidadegeradoraDto
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string IdOrigemcoletausinapai { get; set; } = null!;

    public int CodDpp { get; set; }

    public double? ValPotencianominal { get; set; }

    public int? NumConjunto { get; set; }

    public int? NumMaquina { get; set; }

    public virtual TbOrigemcoletumDto IdOrigemcoletaNavigation { get; set; } = null!;

    public virtual TbAuxUsinaDto IdOrigemcoletausinapaiNavigation { get; set; } = null!;

    public virtual ICollection<TbDadocoletamanutencaoDto> TbDadocoletamanutencaos { get; set; } = new List<TbDadocoletamanutencaoDto>();

    public virtual ICollection<TbManutencaopmoDto> TbManutencaopmos { get; set; } = new List<TbManutencaopmoDto>();
}
