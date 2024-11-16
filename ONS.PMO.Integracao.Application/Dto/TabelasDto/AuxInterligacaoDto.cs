using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class AuxInterligacaoDto
{
    public int IdInterligacao { get; set; }

    public int IdIntercambiopdes { get; set; }

    public string NomIntercambiopdes { get; set; } = null!;

    public virtual ICollection<AuxInterligacaoMontadorInterligacaoDto> TbAuxInterligacaomontadorinterligacaos { get; set; } = new List<AuxInterligacaoMontadorInterligacaoDto>();
}
