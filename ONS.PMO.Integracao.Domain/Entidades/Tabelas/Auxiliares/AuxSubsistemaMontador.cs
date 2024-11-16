using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxSubsistemaMontador
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public int CodSubsistema { get; set; }

    public int? NumTppatamares { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<AuxPequenaUsina> TbAuxPequenausinas { get; set; } = new List<AuxPequenaUsina>();

    public virtual ICollection<AuxSubsistemaContrato> TbAuxSubsistemacontratos { get; set; } = new List<AuxSubsistemaContrato>();

    public virtual ICollection<AuxSubsistemaIntervaloCustoDeficit> TbAuxSubsistemaintervalocustodeficits { get; set; } = new List<AuxSubsistemaIntervaloCustoDeficit>();
}
