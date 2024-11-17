using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbMnemonicoblocoacDto
{
    public int IdMnemonicoblocoac { get; set; }

    public int? IdTpcoleta { get; set; }

    public string NomMnemonicoblocoac { get; set; } = null!;

    public string CodMnemonicoblocoac { get; set; } = null!;

    public bool FlgAtivo { get; set; }

    public bool FlgReservado { get; set; }

    public int NumOrdem { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public int? QtdIndices { get; set; }

    public int? ValColinicialindice { get; set; }

    public int? ValColfinalindice { get; set; }

    public virtual TbTpcoletumDto? IdTpcoletaNavigation { get; set; }

    public virtual ICollection<TbChavemnemonicoestudoDto> TbChavemnemonicoestudos { get; set; } = new List<TbChavemnemonicoestudoDto>();

    public virtual ICollection<TbChavemnemonicoDto> TbChavemnemonicos { get; set; } = new List<TbChavemnemonicoDto>();

    public virtual ICollection<TbGrandezablocoacDto> TbGrandezablocoacs { get; set; } = new List<TbGrandezablocoacDto>();

    public virtual ICollection<TbMnemonicoestudomontadorDto> TbMnemonicoestudomontadors { get; set; } = new List<TbMnemonicoestudomontadorDto>();
}
