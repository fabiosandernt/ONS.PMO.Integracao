using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class MnemonicoBlocoAC
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

    public virtual Coleta? IdTpcoletaNavigation { get; set; }

    public virtual ICollection<ChaveMnemonicoEstudo> TbChavemnemonicoestudos { get; set; } = new List<ChaveMnemonicoEstudo>();

    public virtual ICollection<ChaveMnemonico> TbChavemnemonicos { get; set; } = new List<ChaveMnemonico>();

    public virtual ICollection<GrandezaBlocoAC> TbGrandezablocoacs { get; set; } = new List<GrandezaBlocoAC>();

    public virtual ICollection<MnemonicoEstudoMontador> TbMnemonicoestudomontadors { get; set; } = new List<MnemonicoEstudoMontador>();
}
