using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDecisaocomandognlDto
{
    public int IdDecisaocomandognl { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdTppatamar { get; set; }

    public int IdTitulacao { get; set; }

    public double? ValDespacho { get; set; }

    public DateOnly DatInicial { get; set; }

    public DateOnly DatFinal { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual TbAuxUsinamontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual TbTitulacaoDto IdTitulacaoNavigation { get; set; } = null!;

    public virtual TbTppatamarDto IdTppatamarNavigation { get; set; } = null!;
}
