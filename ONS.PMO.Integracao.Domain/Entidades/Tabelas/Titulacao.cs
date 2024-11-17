using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class Titulacao
{
    public int IdTitulacao { get; set; }

    public string NomTitulacao { get; set; } = null!;

    public string CodTitulacao { get; set; } = null!;

    public virtual ICollection<DecisaoComandoGNL> TbDecisaocomandognls { get; set; } = new List<DecisaoComandoGNL>();
}
