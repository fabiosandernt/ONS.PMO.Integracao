using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbMnemonicoestudomontadorDto
{
    public int IdBlocoestudomontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadomnemonicoestudomontador { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual TbEstadomnemonicoestudomontadorDto IdEstadomnemonicoestudomontadorNavigation { get; set; } = null!;

    public virtual TbEstudomontadorDto IdEstudomontadorNavigation { get; set; } = null!;

    public virtual TbMnemonicoblocoacDto IdMnemonicoblocoacNavigation { get; set; } = null!;
}
