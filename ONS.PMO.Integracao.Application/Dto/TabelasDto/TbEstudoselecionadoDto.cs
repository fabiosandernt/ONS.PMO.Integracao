using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstudoselecionadoDto
{
    public string IdUsuario { get; set; } = null!;

    public int IdEstudomontador { get; set; }

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;
}
