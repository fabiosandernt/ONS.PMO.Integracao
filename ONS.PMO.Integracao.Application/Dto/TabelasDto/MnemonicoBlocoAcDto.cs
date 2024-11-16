using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class MnemonicoBlocoAcDto
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

    public virtual ColetumDto? IdTpcoletaNavigation { get; set; }

    public virtual ICollection<ChaveMnemonicoEstudoDto> TbChavemnemonicoestudos { get; set; } = new List<ChaveMnemonicoEstudoDto>();

    public virtual ICollection<ChaveMnemonicoDto> TbChavemnemonicos { get; set; } = new List<ChaveMnemonicoDto>();

    public virtual ICollection<GrandezaBlocoAcDto> TbGrandezablocoacs { get; set; } = new List<GrandezaBlocoAcDto>();

    public virtual ICollection<MnemonicoEstudoMontadorDto> TbMnemonicoestudomontadors { get; set; } = new List<MnemonicoEstudoMontadorDto>();
}
