using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxInterligacaoMontador
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurtosubsistemade { get; set; } = null!;

    public string CodSubsistemade { get; set; } = null!;

    public string NomCurtosubsistemapara { get; set; } = null!;

    public string CodSubsistemapara { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
