using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class EstadoRestricaoEstudoMontador
{
    public int IdEstadorestricaoestudomontador { get; set; }

    public string DscEstadorestricaoestudomontador { get; set; } = null!;

    public bool FlgEscritarecuperacaodados { get; set; }

    public virtual ICollection<RestricaoEstudo> TbRestricaoestudos { get; set; } = new List<RestricaoEstudo>();
}
