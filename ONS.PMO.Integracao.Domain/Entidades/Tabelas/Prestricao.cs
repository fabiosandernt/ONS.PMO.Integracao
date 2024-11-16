using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class Prestricao
{
    public int IdTprestricao { get; set; }

    public string CodTprestricao { get; set; } = null!;

    public string? DscTprestricao { get; set; }

    public virtual ICollection<RestricaoEstudo> TbRestricaoestudos { get; set; } = new List<RestricaoEstudo>();

    public virtual ICollection<Bloco> IdBlocos { get; set; } = new List<Bloco>();
}
