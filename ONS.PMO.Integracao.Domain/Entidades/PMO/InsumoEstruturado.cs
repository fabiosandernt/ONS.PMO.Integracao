using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class InsumoEstruturado
{
    public int IdInsumopmo { get; set; }

    public int IdTpcategoriainsumo { get; set; }

    public int? IdTpcoleta { get; set; }

    public int? QtdMesesadiante { get; set; }

    public string? TipBlocomontador { get; set; }

    public int? NumOrdemblocomontador { get; set; }

    public virtual InsumoPMO IdInsumopmoNavigation { get; set; } = null!;

    public virtual CategoriaInsumo IdTpcategoriainsumoNavigation { get; set; } = null!;

    public virtual Coleta? IdTpcoletaNavigation { get; set; }

    public virtual ICollection<Grandeza> TbGrandezas { get; set; } = new List<Grandeza>();
}
