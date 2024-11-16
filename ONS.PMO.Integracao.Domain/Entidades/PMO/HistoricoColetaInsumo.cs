using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class HistoricoColetaInsumo
{
    public int IdHistmodifcoletainsumo { get; set; }

    public int? IdTpsituacaocoletainsumo { get; set; }

    public int? IdColetainsumo { get; set; }

    public DateTime DinHistmodifcoletainsumo { get; set; }

    public virtual ColetaInsumo? IdColetainsumoNavigation { get; set; }

    public virtual SituacaoColetaInsumo? IdTpsituacaocoletainsumoNavigation { get; set; }
}
