using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbLimitesintercambioDto
{
    public int IdLimitesintercambio { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdInterligacao { get; set; }

    public string NomInterligacao { get; set; } = null!;

    public string NomDocumentoorigem { get; set; } = null!;

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public int NumOrdem { get; set; }

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual ICollection<TbLimiteperiododiumDto> TbLimiteperiododia { get; set; } = new List<TbLimiteperiododiumDto>();

    public virtual ICollection<TbLimitespatamarDto> TbLimitespatamars { get; set; } = new List<TbLimitespatamarDto>();

    public virtual ICollection<TbReducaolimiteintercambioDto> TbReducaolimiteintercambios { get; set; } = new List<TbReducaolimiteintercambioDto>();
}
