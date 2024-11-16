using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class BlocoDto
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

    public virtual ArquivoExportacaoDto? IdArquivoexportacaoNavigation { get; set; }

    public virtual ColetumDto? IdTpcoletaNavigation { get; set; }

    public virtual EstagioDto? IdTpestagioNavigation { get; set; }

    public virtual ICollection<BlocoEstudoMontadorDto> TbBlocoestudomontadors { get; set; } = new List<BlocoEstudoMontadorDto>();

    public virtual ICollection<ChaveBlocoEstudoDto> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudoDto>();

    public virtual ICollection<ChaveBlocoDto> TbChaveblocos { get; set; } = new List<ChaveBlocoDto>();

    public virtual ICollection<GrandezaBlocoDto> TbGrandezablocos { get; set; } = new List<GrandezaBlocoDto>();

    public virtual ICollection<ModifConfigBlocoEstudoDto> TbModifconfigblocoestudos { get; set; } = new List<ModifConfigBlocoEstudoDto>();

    public virtual ICollection<OrdenacaoRegistroDto> TbOrdenacaoregistros { get; set; } = new List<OrdenacaoRegistroDto>();

    public virtual ICollection<CategoriaInsumoDto> IdTpcategoriainsumos { get; set; } = new List<CategoriaInsumoDto>();

    public virtual ICollection<PrestricaoDto> IdTprestricaos { get; set; } = new List<PrestricaoDto>();
}
