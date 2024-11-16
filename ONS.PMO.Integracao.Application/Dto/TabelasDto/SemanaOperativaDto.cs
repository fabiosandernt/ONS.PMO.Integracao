using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class SemanaOperativaDto
{
    public int IdSemanaoperativa { get; set; }

    public int IdPmo { get; set; }
    
    public string? NomSemanaoperativa { get; set; }

    public int? IdTpsituacaosemanaoper { get; set; }

    public DateTime DatIniciosemana { get; set; }

    public DateTime DatFimsemana { get; set; }

    public DateTime DatReuniao { get; set; }

    public DateTime DatIniciomanutencao { get; set; }

    public DateTime DatFimmanutencao { get; set; }

    public int? NumRevisao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public DateTime? DinUltimaalteracao { get; set; }

    [JsonIgnore]
    public virtual PmoDto IdPmoNavigation { get; set; } = null!;

    [JsonIgnore]
    public virtual SituacaoSemanaOperativaDto? IdTpsituacaosemanaoperNavigation { get; set; }

    public virtual ICollection<ArquivoSemanaOperativaDto> TbArquivosemanaoperativas { get; set; } = new List<ArquivoSemanaOperativaDto>();

    public virtual ICollection<ColetaInsumoDto> TbColetainsumos { get; set; } = new List<ColetaInsumoDto>();

    public virtual ICollection<ConfiguracaoGestaoManutencaoDto> TbConfiguracaogestaomanutencaos { get; set; } = new List<ConfiguracaoGestaoManutencaoDto>();

    public virtual ICollection<DadosConvergenciumDto> TbDadosconvergencia { get; set; } = new List<DadosConvergenciumDto>();

    public virtual ICollection<EstudoMontadorDto> TbEstudomontadors { get; set; } = new List<EstudoMontadorDto>();

    public virtual ICollection<ExportacaoArquivoTextoDto> TbExportacaoarquivotextos { get; set; } = new List<ExportacaoArquivoTextoDto>();

    public virtual ICollection<GabaritoDto> TbGabaritos { get; set; } = new List<GabaritoDto>();

    public virtual ICollection<HistModifSemanaOperDto> TbHistmodifsemanaopers { get; set; } = new List<HistModifSemanaOperDto>();

    public virtual ICollection<ImportacaoPmoDto> TbImportacaopmos { get; set; } = new List<ImportacaoPmoDto>();

    public virtual ICollection<LogNotificacaoDto> TbLognotificacaos { get; set; } = new List<LogNotificacaoDto>();

    public virtual ICollection<RecuperacaoDadoDto> TbRecuperacaodados { get; set; } = new List<RecuperacaoDadoDto>();
}
