using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class InsumoNaoEstruturado
{
    public int IdInsumopmo { get; set; }

    public bool FlgUtilizadodecomp { get; set; }

    public bool FlgUtilizadoconvergencia { get; set; }

    public bool FlgUtilizadopublicacao { get; set; }

    public bool FlgUtilizadoprocessamento { get; set; }

    public virtual InsumoPMO IdInsumopmoNavigation { get; set; } = null!;
}
