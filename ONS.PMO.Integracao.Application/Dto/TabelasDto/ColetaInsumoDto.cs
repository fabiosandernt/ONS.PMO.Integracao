using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

[JsonObject("Insumos")]
public  class ColetaInsumoDto
{
    [JsonPropertyName("id_insumo")]
    public int IdColetainsumo { get; set; }

    public int IdTpsituacaocoletainsumo { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int IdInsumopmo { get; set; }

    public int IdAgenteinstituicao { get; set; }

    public string? DscMotivoalteracaoons { get; set; }

    public string? DscMotivorejeicaoons { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public DateTime? DinUltimaalteracao { get; set; }

    public string? LgnAgenteultimaalteracao { get; set; }

    public string? CodPerfilons { get; set; }

    public string? NomGrandezasnaoestagioalteradas { get; set; }

    public virtual AgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual InsumoPmoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual SemanaOperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual SituacaoColetaInsumoDto IdTpsituacaocoletainsumoNavigation { get; set; } = null!;

    public virtual ICollection<DadoColetumDto> TbDadocoleta { get; set; } = new List<DadoColetumDto>();

    public virtual ICollection<HistmoDifColetaInsumoDto> TbHistmodifcoletainsumos { get; set; } = new List<HistmoDifColetaInsumoDto>();
}
