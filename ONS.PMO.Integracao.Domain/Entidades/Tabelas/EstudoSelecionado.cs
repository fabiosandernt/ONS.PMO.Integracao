using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class EstudoSelecionado
{
    public string IdUsuario { get; set; } = null!;

    public int IdEstudomontador { get; set; }

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;
}
