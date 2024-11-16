using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class Bloco
{
    public int IdBloco { get; set; }

    public int? IdArquivoexportacao { get; set; }

    public int? IdTpestagio { get; set; }

    public int? IdTpcoleta { get; set; }

    public string NomBloco { get; set; } = null!;

    public string? CodBloco { get; set; }

    public int? NumOrdem { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? DscCabecalho { get; set; }

    public bool FlgReservado { get; set; }

    public bool? FlgExpansaousinas { get; set; }

    public bool FlgAtivo { get; set; }

    public bool FlgEspecifico { get; set; }

    public string? FlgExportacaoestagio { get; set; }

    public int? QtdEstagios { get; set; }

    public bool FlgExportado { get; set; }

    public virtual ArquivoExportacao? IdArquivoexportacaoNavigation { get; set; }

    public virtual Coleta? IdTpcoletaNavigation { get; set; }

    public virtual Estagio? IdTpestagioNavigation { get; set; }

    public virtual ICollection<BlocoEstudoMontador> TbBlocoestudomontadors { get; set; } = new List<BlocoEstudoMontador>();

    public virtual ICollection<ChaveBlocoEstudo> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudo>();

    public virtual ICollection<ChaveBloco> TbChaveblocos { get; set; } = new List<ChaveBloco>();

    public virtual ICollection<GrandezaBloco> TbGrandezablocos { get; set; } = new List<GrandezaBloco>();

    public virtual ICollection<ModConfigBlocoEstudo> TbModifconfigblocoestudos { get; set; } = new List<ModConfigBlocoEstudo>();

    public virtual ICollection<OrdenacaoRegistro> TbOrdenacaoregistros { get; set; } = new List<OrdenacaoRegistro>();

    public virtual ICollection<CategoriaInsumo> IdTpcategoriainsumos { get; set; } = new List<CategoriaInsumo>();

    public virtual ICollection<Prestricao> IdTprestricaos { get; set; } = new List<Prestricao>();
}
