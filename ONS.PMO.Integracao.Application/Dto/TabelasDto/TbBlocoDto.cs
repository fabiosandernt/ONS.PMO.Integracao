using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbBlocoDto
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

    public virtual TbArquivoexportacaoDto? IdArquivoexportacaoNavigation { get; set; }

    public virtual TbTpcoletumDto? IdTpcoletaNavigation { get; set; }

    public virtual TbTpestagioDto? IdTpestagioNavigation { get; set; }

    public virtual ICollection<TbBlocoestudomontadorDto> TbBlocoestudomontadors { get; set; } = new List<TbBlocoestudomontadorDto>();

    public virtual ICollection<TbChaveblocoestudoDto> TbChaveblocoestudos { get; set; } = new List<TbChaveblocoestudoDto>();

    public virtual ICollection<TbChaveblocoDto> TbChaveblocos { get; set; } = new List<TbChaveblocoDto>();

    public virtual ICollection<TbGrandezablocoDto> TbGrandezablocos { get; set; } = new List<TbGrandezablocoDto>();

    public virtual ICollection<TbModifconfigblocoestudoDto> TbModifconfigblocoestudos { get; set; } = new List<TbModifconfigblocoestudoDto>();

    public virtual ICollection<TbOrdenacaoregistroDto> TbOrdenacaoregistros { get; set; } = new List<TbOrdenacaoregistroDto>();

    public virtual ICollection<TbTpcategoriainsumoDto> IdTpcategoriainsumos { get; set; } = new List<TbTpcategoriainsumoDto>();

    public virtual ICollection<TbTprestricaoDto> IdTprestricaos { get; set; } = new List<TbTprestricaoDto>();
}
