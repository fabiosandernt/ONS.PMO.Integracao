using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxSubmercado
{
    public string CodSubmercado { get; set; } = null!;

    public int IdOrigemcoletamontador { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
