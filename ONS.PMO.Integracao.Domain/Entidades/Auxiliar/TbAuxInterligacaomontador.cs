using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxInterligacaomontador
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomCurtosubsistemade { get; set; } = null!;

    public string CodSubsistemade { get; set; } = null!;

    public string NomCurtosubsistemapara { get; set; } = null!;

    public string CodSubsistemapara { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
