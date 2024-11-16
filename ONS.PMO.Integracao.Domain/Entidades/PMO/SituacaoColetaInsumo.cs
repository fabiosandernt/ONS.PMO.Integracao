using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class SituacaoColetaInsumo
{
    public int IdTpsituacaocoletainsumo { get; set; }

    public string DscTpsituacaocoletainsumo { get; set; } = null!;

    public virtual ICollection<ColetaInsumo> TbColetainsumos { get; set; } = new List<ColetaInsumo>();

    public virtual ICollection<HistoricoColetaInsumo> TbHistmodifcoletainsumos { get; set; } = new List<HistoricoColetaInsumo>();
}
