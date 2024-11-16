using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DecisaoComandoGNLDto
{
    public int IdDecisaocomandognl { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdTppatamar { get; set; }

    public int IdTitulacao { get; set; }

    public double? ValDespacho { get; set; }

    public DateOnly DatInicial { get; set; }

    public DateOnly DatFinal { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual AuxUsinaMontadorDto? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual TitulacaoDto IdTitulacaoNavigation { get; set; } = null!;

    public virtual PatamarDto IdTppatamarNavigation { get; set; } = null!;
}
