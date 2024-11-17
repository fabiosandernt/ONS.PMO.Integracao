using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxUnidadegeradora
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string IdOrigemcoletausinapai { get; set; } = null!;

    public int CodDpp { get; set; }

    public double? ValPotencianominal { get; set; }

    public int? NumConjunto { get; set; }

    public int? NumMaquina { get; set; }

    public virtual OrigemColetum IdOrigemcoletaNavigation { get; set; } = null!;

    public virtual TbAuxUsina IdOrigemcoletausinapaiNavigation { get; set; } = null!;

    public virtual ICollection<DadoColetaManutencao> TbDadocoletamanutencaos { get; set; } = new List<DadoColetaManutencao>();

    public virtual ICollection<ManutencaoPmo> TbManutencaopmos { get; set; } = new List<ManutencaoPmo>();
}
