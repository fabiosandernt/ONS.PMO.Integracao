using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class ManutencaoProgramadum
{
    public int IdTpmanutencaoprogramada { get; set; }

    public string NomTpmanutencaoprogramada { get; set; } = null!;

    public virtual ICollection<ManutencaoPrograma> TbManutencaoprogramada { get; set; } = new List<ManutencaoPrograma>();
}
