using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class EstadoManutencaoPMO
{
    public int IdEstadomanutencaopmo { get; set; }

    public string DscEstado { get; set; } = null!;

    public virtual ICollection<ManutencaoPMO> TbManutencaopmos { get; set; } = new List<ManutencaoPMO>();
}
