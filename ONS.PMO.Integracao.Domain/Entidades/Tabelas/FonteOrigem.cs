using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class FonteOrigem
{
    public int IdFonteorigem { get; set; }

    public string NomFonteorigem { get; set; } = null!;

    public bool FlgEletrica { get; set; }

    public bool FlgHidraulica { get; set; }

    public virtual ICollection<Restricao> TbRestricaos { get; set; } = new List<Restricao>();
}
