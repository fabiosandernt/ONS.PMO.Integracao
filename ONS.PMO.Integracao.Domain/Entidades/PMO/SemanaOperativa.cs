using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class SemanaOperativa
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

    public virtual Pmo IdPmoNavigation { get; set; } = null!;

    public virtual SituacaoSemanaOperativa? IdTpsituacaosemanaoperNavigation { get; set; }

    public virtual ICollection<ArquivoSemanaOperativa> TbArquivosemanaoperativas { get; set; } = new List<ArquivoSemanaOperativa>();

    public virtual ICollection<ColetaInsumo> TbColetainsumos { get; set; } = new List<ColetaInsumo>();

    //public virtual ICollection<ConfiguracaoGestaoManutencao> TbConfiguracaogestaomanutencaos { get; set; } = new List<ConfiguracaoGestaoManutencao>();

    public virtual ICollection<DadosConvergencia> TbDadosconvergencia { get; set; } = new List<DadosConvergencia>();

    //public virtual ICollection<EstudoMontador> TbEstudomontadors { get; set; } = new List<EstudoMontador>();

    //public virtual ICollection<ExportacaoArquivoTexto> TbExportacaoarquivotextos { get; set; } = new List<ExportacaoArquivoTexto>();

    public virtual ICollection<Gabarito> TbGabaritos { get; set; } = new List<Gabarito>();

    //public virtual ICollection<HistoricoModificacaoSemanaOperativa> TbHistmodifsemanaopers { get; set; } = new List<HistoricoModificacaoSemanaOperativa>();

    //public virtual ICollection<ImportacaoPmo> TbImportacaopmos { get; set; } = new List<ImportacaoPmo>();

    //public virtual ICollection<LogNotificacao> TbLognotificacaos { get; set; } = new List<LogNotificacao>();

    //public virtual ICollection<RecuperacaoDado> TbRecuperacaodados { get; set; } = new List<RecuperacaoDado>();
}
