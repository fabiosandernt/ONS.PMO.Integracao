using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxMnemonicoMontadorDto
{
    public int IdOrigemcoletamontador { get; set; }

    public string NomMnemonico { get; set; } = null!;

    public virtual OrigemColetaMontadorDto IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual ICollection<AuxUsinaMnemonicoDto> TbAuxUsinamnemonicos { get; set; } = new List<AuxUsinaMnemonicoDto>();
}
