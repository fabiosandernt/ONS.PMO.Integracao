using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class ChaveMnemonico
{
    public int IdMnemonicoblocoac { get; set; }

    public int IdCampochave { get; set; }

    public bool FlgDispmanutencao { get; set; }

    public bool FlgDispexportacao { get; set; }

    public bool FlgGeralinhacomentario { get; set; }

    public virtual CampoChave IdCampochaveNavigation { get; set; } = null!;

    public virtual MnemonicoBlocoAC IdMnemonicoblocoacNavigation { get; set; } = null!;
}
