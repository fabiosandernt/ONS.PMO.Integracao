using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class CategoriaInsumo
{
    public int IdTpcategoriainsumo { get; set; }

    public string DscTpcategoriainsumo { get; set; } = null!;

    public bool FlgMontador { get; set; }

    public bool FlgPmo { get; set; }

    public virtual ICollection<InsumoEstruturado> TbInsumoestruturados { get; set; } = new List<InsumoEstruturado>();

    public virtual ICollection<Bloco> IdBlocos { get; set; } = new List<Bloco>();
}
