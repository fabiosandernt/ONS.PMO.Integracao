using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class LimitesIntercambioDto
{
    public int IdLimitesintercambio { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdInterligacao { get; set; }

    public string NomInterligacao { get; set; } = null!;

    public string NomDocumentoorigem { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public int NumOrdem { get; set; }

    public virtual EstudoMontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual ICollection<LimitePeriodoDto> TbLimiteperiododia { get; set; } = new List<LimitePeriodoDto>();

    public virtual ICollection<LimitesPatamarDto> TbLimitespatamars { get; set; } = new List<LimitesPatamarDto>();

    public virtual ICollection<ReducaoLimiteIntercambioDto> TbReducaolimiteintercambios { get; set; } = new List<ReducaoLimiteIntercambioDto>();
}
