using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpmanutencaoprogramadumDto
{
    public int IdTpmanutencaoprogramada { get; set; }

    public string NomTpmanutencaoprogramada { get; set; } = null!;

    public virtual ICollection<TbManutencaoprogramadumDto> TbManutencaoprogramada { get; set; } = new List<TbManutencaoprogramadumDto>();
}
