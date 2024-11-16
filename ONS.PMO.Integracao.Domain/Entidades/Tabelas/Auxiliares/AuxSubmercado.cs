using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxSubmercado
{
    public string CodSubmercado { get; set; } = null!;

    public int IdOrigemcoletamontador { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
