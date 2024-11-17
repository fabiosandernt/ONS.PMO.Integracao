using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbCampochaveDto
{
    public int IdCampochave { get; set; }

    public string CodCampochave { get; set; } = null!;

    public string DscCampochave { get; set; } = null!;

    public virtual ICollection<TbCampochavetpcoletumDto> TbCampochavetpcoleta { get; set; } = new List<TbCampochavetpcoletumDto>();

    public virtual ICollection<TbChaveblocoDto> TbChaveblocos { get; set; } = new List<TbChaveblocoDto>();

    public virtual ICollection<TbChavemnemonicoDto> TbChavemnemonicos { get; set; } = new List<TbChavemnemonicoDto>();

    public virtual ICollection<TbOrdenacaoregistroDto> TbOrdenacaoregistros { get; set; } = new List<TbOrdenacaoregistroDto>();

    public virtual ICollection<TbModifconfigblocoestudoDto> IdModifconfigblocoestudos { get; set; } = new List<TbModifconfigblocoestudoDto>();
}
