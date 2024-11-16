using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class EstudoSelecionadoDto
{
    public string IdUsuario { get; set; } = null!;

    public int IdEstudomontador { get; set; }

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;
}
