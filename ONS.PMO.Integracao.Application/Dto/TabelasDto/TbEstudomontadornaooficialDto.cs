using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstudomontadornaooficialDto
{
    public int IdEstudomontador { get; set; }

    public string AgeId { get; set; } = null!;

    public string LgnUsuario { get; set; } = null!;

    public string NomEstudonaooficial { get; set; } = null!;

    public string CodEstudonaooficial { get; set; } = null!;

    public DateTime DatIniciosemana { get; set; }

    public DateTime DatFimsemana { get; set; }

    public int? NumRevisao { get; set; }

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;
}
