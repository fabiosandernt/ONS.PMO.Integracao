using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class ConfiguracaoGestaoManutencao
{
    public int IdConfiguracaogestaomanutencao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public TimeOnly HorPonta { get; set; }

    public int QtdPeriodoanalise { get; set; }

    public DateTime DinColeta { get; set; }

    public string LgnColeta { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual SemanaOperativa IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual ICollection<DemandaIntegral> TbDemandaintegrals { get; set; } = new List<DemandaIntegral>();

    public virtual ICollection<GeracaoPequenasUsina> TbGeracaopequenasusinas { get; set; } = new List<GeracaoPequenasUsina>();

    public virtual ICollection<GeracaoTermica> TbGeracaotermicas { get; set; } = new List<GeracaoTermica>();

    public virtual ICollection<ManutencaoPMO> TbManutencaopmos { get; set; } = new List<ManutencaoPMO>();

    public virtual ICollection<PerdaPotencium> TbPerdapotencia { get; set; } = new List<PerdaPotencium>();

    public virtual ICollection<Agenteinstituicao> IdAgenteinstituicaos { get; set; } = new List<Agenteinstituicao>();
}
