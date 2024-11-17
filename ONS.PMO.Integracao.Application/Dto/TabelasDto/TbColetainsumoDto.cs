using Newtonsoft.Json;
using ONS.PMO.Integracao.Application.Dto.PMO;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

[JsonObject("Insumos")]
public  class TbColetainsumoDto
{
    //[JsonPropertyName("id_insumo")]
    public int IdColetainsumo { get; set; }

    public int IdTpsituacaocoletainsumo { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int IdInsumopmo { get; set; }

    public int IdAgenteInstituicao { get; set; }

    public string? DscMotivoalteracaoons { get; set; }

    public string? DscMotivorejeicaoons { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public DateTime? DinUltimaalteracao { get; set; }

    public string? LgnAgenteultimaalteracao { get; set; }

    public string? CodPerfilons { get; set; }

    public string? NomGrandezasnaoestagioalteradas { get; set; }

    public virtual TbAgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual TbInsumopmoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual TbSemanaoperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual TbTpsituacaocoletainsumoDto IdTpsituacaocoletainsumoNavigation { get; set; } = null!;

    public virtual ICollection<TbDadocoletumDto> TbDadocoleta { get; set; } = new List<TbDadocoletumDto>();

    public virtual ICollection<TbHistmodifcoletainsumoDto> TbHistmodifcoletainsumos { get; set; } = new List<TbHistmodifcoletainsumoDto>();
}
