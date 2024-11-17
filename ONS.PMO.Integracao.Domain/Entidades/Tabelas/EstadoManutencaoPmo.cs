using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class EstadoManutencaoPmo
{
    public int IdEstadomanutencaopmo { get; set; }

    public string DscEstado { get; set; } = null!;

    public virtual ICollection<ManutencaoPmo> TbManutencaopmos { get; set; } = new List<ManutencaoPmo>();
}
