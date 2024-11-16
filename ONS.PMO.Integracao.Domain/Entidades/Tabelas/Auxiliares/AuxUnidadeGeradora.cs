using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxUnidadeGeradora
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string IdOrigemcoletausinapai { get; set; } = null!;

    public int CodDpp { get; set; }

    public double? ValPotencianominal { get; set; }

    public int? NumConjunto { get; set; }

    public int? NumMaquina { get; set; }

    public virtual OrigemColetum IdOrigemcoletaNavigation { get; set; } = null!;

    public virtual AuxUsina IdOrigemcoletausinapaiNavigation { get; set; } = null!;

    public virtual ICollection<DadoColetaManutencao> TbDadocoletamanutencaos { get; set; } = new List<DadoColetaManutencao>();

    public virtual ICollection<ManutencaoPMO> TbManutencaopmos { get; set; } = new List<ManutencaoPMO>();
}
