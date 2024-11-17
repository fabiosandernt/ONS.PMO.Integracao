using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbAuxConjmaqmontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdGruge { get; set; }

    public string NomCurtousina { get; set; } = null!;

    public int CodDppusina { get; set; }

    public virtual TbOrigemcoletamontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
