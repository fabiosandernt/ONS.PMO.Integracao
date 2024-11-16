using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ConfiguracaoGestaoManutencaoDto
{
    public int IdConfiguracaogestaomanutencao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public TimeOnly HorPonta { get; set; }

    public int QtdPeriodoanalise { get; set; }

    public DateTime DinColeta { get; set; }

    public string LgnColeta { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual SemanaOperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual ICollection<DemandaIntegralDto> TbDemandaintegrals { get; set; } = new List<DemandaIntegralDto>();

    public virtual ICollection<GeracaoPequenasUsinaDto> TbGeracaopequenasusinas { get; set; } = new List<GeracaoPequenasUsinaDto>();

    public virtual ICollection<GeracaoTermicaDto> TbGeracaotermicas { get; set; } = new List<GeracaoTermicaDto>();

    public virtual ICollection<ManutencaoPmoDto> TbManutencaopmos { get; set; } = new List<ManutencaoPmoDto>();

    public virtual ICollection<PerdaPotenciumDto> TbPerdapotencia { get; set; } = new List<PerdaPotenciumDto>();

    public virtual ICollection<AgenteinstituicaoDto> IdAgenteinstituicaos { get; set; } = new List<AgenteinstituicaoDto>();
}
