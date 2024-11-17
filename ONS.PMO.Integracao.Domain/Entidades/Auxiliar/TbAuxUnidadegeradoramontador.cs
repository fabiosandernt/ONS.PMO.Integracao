using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxUnidadegeradoramontador
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

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontador? IdOrigemcoletamontadorusinaNavigation { get; set; }

    public virtual ICollection<ManutencaoProgramada> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramada>();
}
