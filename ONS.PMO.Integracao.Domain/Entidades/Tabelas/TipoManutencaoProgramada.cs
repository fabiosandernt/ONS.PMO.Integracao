using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class TipoManutencaoProgramada
{
    public int IdTpmanutencaoprogramada { get; set; }

    public string NomTpmanutencaoprogramada { get; set; } = null!;

    public virtual ICollection<ManutencaoProgramada> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramada>();
}
