using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ManutencaoProgramadumDto
{
    public int IdTpmanutencaoprogramada { get; set; }

    public string NomTpmanutencaoprogramada { get; set; } = null!;

    public virtual ICollection<ManutencaoProgramadaDto> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramadaDto>();
}
