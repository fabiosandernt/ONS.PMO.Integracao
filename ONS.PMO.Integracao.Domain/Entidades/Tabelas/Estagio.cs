using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class Estagio
{
    public int IdTpestagio { get; set; }

    public string DscTpestagio { get; set; } = null!;

    public virtual ICollection<Bloco> TbBlocos { get; set; } = new List<Bloco>();
}
