using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class CampoChaveDto
{
    public int IdCampochave { get; set; }

    public string CodCampochave { get; set; } = null!;

    public string DscCampochave { get; set; } = null!;

    public virtual ICollection<CampoChaveColetumDto> TbCampochavetpcoleta { get; set; } = new List<CampoChaveColetumDto>();

    public virtual ICollection<ChaveBlocoDto> TbChaveblocos { get; set; } = new List<ChaveBlocoDto>();

    public virtual ICollection<ChaveMnemonicoDto> TbChavemnemonicos { get; set; } = new List<ChaveMnemonicoDto>();

    public virtual ICollection<OrdenacaoRegistroDto> TbOrdenacaoregistros { get; set; } = new List<OrdenacaoRegistroDto>();

    public virtual ICollection<ModifConfigBlocoEstudoDto> IdModifconfigblocoestudos { get; set; } = new List<ModifConfigBlocoEstudoDto>();
}
