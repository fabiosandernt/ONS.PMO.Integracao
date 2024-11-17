using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxSubsistema
{
    public string IdOrigemcoleta { get; set; } = null!;

    public string CodSubsistema { get; set; } = null!;

    public virtual OrigemColetum IdOrigemcoletaNavigation { get; set; } = null!;
}
