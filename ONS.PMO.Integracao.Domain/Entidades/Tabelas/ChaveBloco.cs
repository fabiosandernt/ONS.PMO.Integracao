using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ChaveBloco
{
    public int IdBloco { get; set; }

    public int IdCampochave { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public bool FlgDispmanutencao { get; set; }

    public bool FlgDispexportacao { get; set; }

    public bool FlgGeralinhacomentario { get; set; }

    public virtual Bloco IdBlocoNavigation { get; set; } = null!;

    public virtual CampoChave IdCampochaveNavigation { get; set; } = null!;
}
